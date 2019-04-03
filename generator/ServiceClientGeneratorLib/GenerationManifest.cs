﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json.LitJson;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Loads the generator control manifest document. This document
    /// yields the Visual Studio project metadata (for new project files
    /// that we create) and the set of service configurations available
    /// to process.
    /// </summary>
    public class GenerationManifest
    {
        abstract class ModelsSectionKeys
        {
            public const string ModelsKey = "models";
            public const string ActiveKey = "active";
            public const string NamespaceKey = "namespace";
            public const string BaseNameKey = "base-name";
            public const string NugetPackageTitleSuffix = "nuget-package-title-suffix";
            public const string DefaultRegionKey = "default-region";
            public const string GenerateClientConstructorsKey = "generate-client-constructors";
            public const string CustomizationFileKey = "customization-file";
            public const string MaxRetriesKey = "max-retries";
            public const string SynopsisKey = "synopsis";
            public const string NetStandardSupportKey = "netstandard-support";
            public const string DependenciesKey = "dependencies";
            public const string PlatformsKey = "platforms";
            public const string ReferenceDependenciesKey = "reference-dependencies";
            public const string NugetDependenciesKey = "nuget-dependencies";
            public const string PclVariantsKey = "pcl-variants";
            public const string DependencyNameKey = "name";
            public const string DependencyVersionKey = "version";
            public const string DependencyHintPathKey = "hint-path";
            public const string ParentBaseNameKey = "parent-base-name";
            public const string EnableXamarinComponent = "enable-xamarin-component";
            public const string TagsKey = "tags";
            public const string UsePclProjectDependenciesKey = "use-pcl-project-dependencies";
            public const string LicenseUrlKey = "license-url";

        }

        abstract class ProjectsSectionKeys
        {
            public const string ProjectsKey = "projects";
            public const string NameKey = "name";
            public const string ConfigurationsKey = "configurations";
            public const string TargetFrameworksKey = "targetFrameworks";
            public const string DefineConstantsKey = "defineConstants";
            public const string BinSubFolderKey = "binSubFolder";
            public const string TemplateKey = "template";
            public const string PlatformCodeFoldersKey = "platformCodeFolders";
            public const string ExtraTestProjects = "extraTestProjects";
            public const string ParentProfile = "parentProfile";
            public const string NuGetTargetFrameworkKey = "nugetTargetPlatform";
            public const string SharedNugetTargetFrameworksKey = "sharedNugetTargetFrameworks";
            public const string PlatformExcludeFoldersKey = "excludeFolders";
            public const string FrameworkPathOverrideKey = "frameworkPathOverride";
            public const string FrameworkRefernecesKey = "frameworkReferences";
            public const string VisualStudioServicesKey = "visualStudioServices";
            public const string EmbeddedResourcesKey = "embeddedResources";
            public const string UnitTestProjectsKey = "unittestprojects";
            public const string NoWarn = "noWarn";
            public const string PackageReferences = "packageReferences";
            public const string OutputPathOverrideKey = "outputPathOverride";
        }

        /// <summary>
        /// URL for Apache License 2.0
        /// </summary>
        public const string ApacheLicenseURL = @"http://aws.amazon.com/apache2.0/";

        /// <summary>
        /// The set of services declared in the manifest as supporting generation. 
        /// </summary>
        public IEnumerable<ServiceConfiguration> ServiceConfigurations { get; private set; }

        //public IDictionary<string, string> ServiceVersions { get; private set; }

        /// <summary>
        /// The set of per-platform project metadata needed to generate a platform
        /// specific project file for a service.
        /// </summary>
        public IEnumerable<ProjectFileConfiguration> ProjectFileConfigurations { get; private set; }

        public IEnumerable<ProjectFileConfiguration> UnitTestProjectFileConfigurations { get; private set; }

        public string CoreVersion
        {
            get
            {
                return Utils.GetVersion(CoreFileVersion);
            }
        }
        public string CoreFileVersion { get; private set; }

        public bool DefaultToPreview
        {
            get;
            private set;
        }

        public string PreviewLabel
        {
            get;
            private set;
        }

        //This should be the same version number as SdkVersioning.DefaultAssemblyVersion in BuildTasks
        private const string DefaultAssemblyVersion = "3.3.100.0";
 
        /// <summary>
        /// Processes the control manifest to yield the set of services available to
        /// generate and the Visual Studio project file information used to create
        /// new projects for services.
        /// </summary>
        /// <param name="manifestPath">Path to the manifest file to pull basic info from</param>
        /// <param name="versionsPath">Path to _sdk-versions.json file</param>
        /// <param name="modelsFolder">Path to the service models to be parsed</param>
        public static GenerationManifest Load(string manifestPath, string versionsPath, string modelsFolder)
        {
            var generationManifest = new GenerationManifest();
            var manifest = LoadJsonFromFile(manifestPath);
            var versionsManifest = LoadJsonFromFile(versionsPath);

            generationManifest.CoreFileVersion = versionsManifest["CoreVersion"].ToString();
            generationManifest.DefaultToPreview = (bool)versionsManifest["DefaultToPreview"];
            if (generationManifest.DefaultToPreview)
            {
                generationManifest.PreviewLabel = (string)versionsManifest["PreviewLabel"];
            }
            if (!string.IsNullOrEmpty(generationManifest.PreviewLabel))
                generationManifest.PreviewLabel = "-" + generationManifest.PreviewLabel;

            generationManifest.LoadServiceConfigurations(manifest, versionsManifest["ServiceVersions"], modelsFolder);
            generationManifest.LoadProjectConfigurations(manifest);
            generationManifest.LoadUnitTestProjectConfigurations(manifest);

            return generationManifest;
        }

        /// <summary>
        /// Recursively walk thorugh the ServiceModels folder and load/parse the 
        /// model files to generate ServiceConfiguration objects.
        /// </summary>
        /// <param name="manifest">loaded _manifest.json file</param>
        /// <param name="serviceVersions">loaded _sdk-versions.json file</param>
        /// <param name="serviceModelsFolder">path to ServiceModels directory folder</param>
        void LoadServiceConfigurations(JsonData manifest, JsonData serviceVersions, string serviceModelsFolder)
        {
            List<Tuple<JsonData, ServiceConfiguration>> modelConfigList = new List<Tuple<JsonData, ServiceConfiguration>>();
            var serviceConfigurations = new List<ServiceConfiguration>();

            var serviceDirectories = Directory.GetDirectories(Path.Combine(serviceModelsFolder));
            foreach (string serviceDirectory in serviceDirectories)
            {
                string metadataJsonFile = Path.Combine(serviceDirectory, "metadata.json");
                if (File.Exists(metadataJsonFile))
                {
                    JsonData metadataNode = LoadJsonFromFile(metadataJsonFile);

                    var activeNode = metadataNode[ModelsSectionKeys.ActiveKey];
                    if (    activeNode != null
                        &&  activeNode.IsBoolean
                        && !(bool)activeNode )
                    {
                        continue;                             
                    }

                    var serviceModelFileName = GetLatestModel(serviceDirectory);
                    var config = CreateServiceConfiguration(metadataNode, serviceVersions, serviceDirectory, serviceModelFileName);
                    serviceConfigurations.Add(config);

                    modelConfigList.Add(new Tuple<JsonData, ServiceConfiguration>(metadataNode, config));
                }
            }

            //We need to make sure that we have configuration files for all expected services and that there aren't mismatches in the service names
            foreach (string serviceVersionEntry in serviceVersions.GetMap().Keys)
            {
                if (!serviceConfigurations.Any(config => config.ServiceNameRoot == serviceVersionEntry))
                {
                    throw new Exception($"Service entry {serviceVersionEntry} doesn't match any of the available service configurations.");
                }
            }

            // The parent model for current model, if set, the client will be generated
            // in the same namespace and share common types.

            foreach (var modelConfig in modelConfigList)
            {
                var modelNode = modelConfig.Item1;
                var config = modelConfig.Item2;

                var parentClassName = modelNode[ModelsSectionKeys.ParentBaseNameKey] != null ? modelNode[ModelsSectionKeys.ParentBaseNameKey].ToString() : null;
                if (parentClassName != null)
                {
                    try
                    {
                        config.ParentConfig = serviceConfigurations.Single(c => c.ClassName.Equals(parentClassName));
                    }
                    catch (KeyNotFoundException exception)
                    {
                        // Note : the parent model should be defined in the manifest before being referred by a child model
                        throw new KeyNotFoundException(
                            string.Format("A parent model with name {0} is not defined in the manifest", parentClassName),
                            exception); ;
                    }
                }
            }

            ServiceConfigurations = serviceConfigurations
                .OrderBy(sc => sc.ServiceDependencies.Count)
                .ToList();
        }

        private static string GetLatestModel(string serviceDirectory)
        {
            string latestModelName="";
            foreach (string modelName in Directory.GetFiles(serviceDirectory, "*.normal.json", SearchOption.TopDirectoryOnly))
            {
                if (string.Compare(latestModelName, modelName) < 0)
                {
                    latestModelName = modelName;
                }
            }

            if (string.IsNullOrEmpty(latestModelName))
            {
                throw new FileNotFoundException("Failed to find a model file in " + serviceDirectory);
            }

            return Path.GetFileName(latestModelName);
        }

        private ServiceConfiguration CreateServiceConfiguration(JsonData modelNode, JsonData serviceVersions, string serviceDirectoryPath, string serviceModelFileName)
        {
            var modelFullPath = Path.Combine(serviceDirectoryPath, serviceModelFileName);

            JsonData metadata = JsonMapper.ToObject(File.ReadAllText(modelFullPath))[ServiceModel.MetadataKey];

            // A new config that the api generates from            
            var modelName = Path.GetFileName(serviceDirectoryPath);
            var config = new ServiceConfiguration
            {
                ModelName = modelName,
                ModelPath = modelFullPath,
                Namespace = Utils.JsonDataToString(modelNode[ModelsSectionKeys.NamespaceKey]), // Namespace of the service if it's different from basename
                ClassNameOverride = Utils.JsonDataToString(modelNode[ModelsSectionKeys.BaseNameKey]),
                DefaultRegion = Utils.JsonDataToString(modelNode[ModelsSectionKeys.DefaultRegionKey]),
                GenerateConstructors = modelNode[ModelsSectionKeys.GenerateClientConstructorsKey] == null || (bool)modelNode[ModelsSectionKeys.GenerateClientConstructorsKey], // A way to prevent generating basic constructors
                SupportedMobilePlatforms = modelNode[ModelsSectionKeys.PlatformsKey] == null ? new List<string>() : (from object pcf in modelNode[ModelsSectionKeys.PlatformsKey]
                                                                                                                        select pcf.ToString()).ToList(),
                EnableXamarinComponent = modelNode.PropertyNames.Contains(ModelsSectionKeys.EnableXamarinComponent) && (bool)modelNode[ModelsSectionKeys.EnableXamarinComponent]
            };

            if (modelNode[ModelsSectionKeys.PclVariantsKey] != null)
            {
                config.PclVariants = (from object pcf in modelNode[ModelsSectionKeys.PclVariantsKey]
                    select pcf.ToString()).ToList();
            }

            if (modelNode[ModelsSectionKeys.NugetPackageTitleSuffix] != null)
                config.NugetPackageTitleSuffix = modelNode[ModelsSectionKeys.NugetPackageTitleSuffix].ToString();


            if (modelNode[ModelsSectionKeys.ReferenceDependenciesKey] != null)
            {
                config.ReferenceDependencies = new Dictionary<string, List<Dependency>>();
                foreach (KeyValuePair<string, JsonData> kvp in modelNode[ModelsSectionKeys.ReferenceDependenciesKey])
                {
                    var platformDependencies = new List<Dependency>();
                    foreach (JsonData item in kvp.Value)
                    {
                        var platformDependency = new Dependency
                        {
                            Name = item[ModelsSectionKeys.DependencyNameKey].ToString(),
                            Version = item.PropertyNames.Contains(ModelsSectionKeys.DependencyVersionKey) ? item[ModelsSectionKeys.DependencyVersionKey].ToString() : "0.0.0.0",
                            HintPath = item[ModelsSectionKeys.DependencyHintPathKey].ToString(),
                        };
                        platformDependencies.Add(platformDependency);
                    }
                    config.ReferenceDependencies.Add(kvp.Key, platformDependencies);
                }
            }

            if (modelNode[ModelsSectionKeys.NugetDependenciesKey] != null)
            {
                config.NugetDependencies = new Dictionary<string, List<Dependency>>();
                foreach (KeyValuePair<string, JsonData> kvp in modelNode[ModelsSectionKeys.NugetDependenciesKey])
                {
                    var nugetDependencies = new List<Dependency>();
                    foreach (JsonData item in kvp.Value)
                    {
                        var nugetDependency = new Dependency
                        {
                            Name = item[ModelsSectionKeys.DependencyNameKey].ToString(),
                            Version = item[ModelsSectionKeys.DependencyVersionKey].ToString(),
                        };
                        nugetDependencies.Add(nugetDependency);
                    }
                    config.NugetDependencies.Add(kvp.Key, nugetDependencies);
                }
            }

            config.Tags = new List<string>();
            if (modelNode[ModelsSectionKeys.TagsKey] != null)
            {
                foreach (JsonData tag in modelNode[ModelsSectionKeys.TagsKey])
                {
                    config.Tags.Add(tag.ToString());
                }
            }

            // Provides a way to specify a customizations file rather than using a generated one
            config.CustomizationsPath = modelNode[ModelsSectionKeys.CustomizationFileKey] == null
                ? DetermineCustomizationsPath(config.ServiceDirectoryName)
                : Path.Combine(serviceDirectoryPath, modelNode[ModelsSectionKeys.CustomizationFileKey].ToString());

            if (modelNode[ModelsSectionKeys.MaxRetriesKey] != null && modelNode[ModelsSectionKeys.MaxRetriesKey].IsInt)
                config.OverrideMaxRetries = Convert.ToInt32(modelNode[ModelsSectionKeys.MaxRetriesKey].ToString());

            if (modelNode[ModelsSectionKeys.SynopsisKey] != null)
                config.Synopsis = (string)modelNode[ModelsSectionKeys.SynopsisKey];

            if (modelNode[ModelsSectionKeys.NetStandardSupportKey] != null)
                config.NetStandardSupport = (bool)modelNode[ModelsSectionKeys.NetStandardSupportKey];
            else
                config.NetStandardSupport = true;

            config.ServiceDependencies = new Dictionary<string, string>(StringComparer.Ordinal);
            if (modelNode[ModelsSectionKeys.DependenciesKey] != null && modelNode[ModelsSectionKeys.DependenciesKey].IsArray)
            {
                foreach (var d in modelNode[ModelsSectionKeys.DependenciesKey])
                {
                    config.ServiceDependencies.Add(d.ToString(), null);
                }
            }

            if (modelNode[ModelsSectionKeys.UsePclProjectDependenciesKey] != null && modelNode[ModelsSectionKeys.UsePclProjectDependenciesKey].IsBoolean)
                config.UsePclProjectDependencies = bool.Parse(modelNode[ModelsSectionKeys.UsePclProjectDependenciesKey].ToString());
            else
                config.UsePclProjectDependencies = false;

            if (modelNode[ModelsSectionKeys.LicenseUrlKey] != null && modelNode[ModelsSectionKeys.LicenseUrlKey].IsString)
            {
                config.LicenseUrl = modelNode[ModelsSectionKeys.LicenseUrlKey].ToString();
                config.RequireLicenseAcceptance = true;
            }
            else
                config.LicenseUrl = ApacheLicenseURL;

            var serviceName = config.ServiceNameRoot;
            var versionInfoJson = serviceVersions[serviceName];
            if (versionInfoJson != null)
            {
                var dependencies = versionInfoJson["Dependencies"];
                foreach (var name in dependencies.PropertyNames)
                {
                    var version = dependencies[name].ToString();
                    config.ServiceDependencies[name] = version;
                }


                var versionText = versionInfoJson["Version"].ToString();
                config.ServiceFileVersion = versionText;

                var assemblyVersionOverride = versionInfoJson["AssemblyVersionOverride"];
                if (assemblyVersionOverride != null)
                {
                    config.ServiceAssemblyVersionOverride = assemblyVersionOverride.ToString();
                }

                if(versionInfoJson["InPreview"] != null && (bool)versionInfoJson["InPreview"])
                    config.InPreview = true;
                else
                    config.InPreview = this.DefaultToPreview;
            }
            else
            {
                config.ServiceDependencies["Core"] = CoreFileVersion;
                config.InPreview = this.DefaultToPreview;

                config.ServiceFileVersion = DefaultAssemblyVersion;
                var versionTokens = CoreVersion.Split('.');
                if (!DefaultAssemblyVersion.StartsWith($"{versionTokens[0]}.{versionTokens[1]}."))
                {
                    throw new NotImplementedException($"{nameof(DefaultAssemblyVersion)} should be updated to match the AWSSDK.Core minor version number.");
                }
            }

            return config;
        }

        private static List<string> SafeGetStringList(JsonData data, string key)
        {
            var t = data.SafeGet(key);
            if (t != null)
            {
                return (from object obj in t select obj.ToString()).ToList<string>();
            }
            else
            {
                return new List<string>();
            }
        }

        private static List<T> SafeGetObjectList<T>(JsonData data, string key, Func<JsonData, T> converter)
        {
            var t = data.SafeGet(key);
            if (t != null)
            {
                return (from JsonData obj in t select converter(obj)).ToList<T>();
            }
            else
            {
                return new List<T>();
            }
        }

        private static ProjectFileConfiguration LoadProjectFileConfiguration(JsonData node)
        {
            return new ProjectFileConfiguration{
                Name                            = node.SafeGetString(ProjectsSectionKeys.NameKey),
                TargetFrameworkVersions         = SafeGetStringList(node, ProjectsSectionKeys.TargetFrameworksKey),
                CompilationConstants            = SafeGetStringList(node, ProjectsSectionKeys.DefineConstantsKey),
                BinSubFolder                    = node.SafeGetString(ProjectsSectionKeys.BinSubFolderKey),
                Template                        = node.SafeGetString(ProjectsSectionKeys.TemplateKey),
                NuGetTargetPlatform             = node.SafeGetString(ProjectsSectionKeys.NuGetTargetFrameworkKey),
                FrameworkPathOverride           = node.SafeGetString(ProjectsSectionKeys.FrameworkPathOverrideKey),
                NoWarn                          = node.SafeGetString(ProjectsSectionKeys.NoWarn),
                OutputPathOverride              = node.SafeGetString(ProjectsSectionKeys.OutputPathOverrideKey),
                Configurations                  = SafeGetStringList(node, ProjectsSectionKeys.ConfigurationsKey),
                EmbeddedResources               = SafeGetStringList(node, ProjectsSectionKeys.EmbeddedResourcesKey),
                PlatformCodeFolders             = SafeGetStringList(node, ProjectsSectionKeys.PlatformCodeFoldersKey),
                PlatformExcludeFolders          = SafeGetStringList(node, ProjectsSectionKeys.PlatformExcludeFoldersKey),
                DllReferences                   = SafeGetObjectList<Dependency>(node, ProjectsSectionKeys.FrameworkRefernecesKey, Dependency.ParseJson),
                PackageReferences               = SafeGetObjectList<ProjectFileCreator.PackageReference>(node, ProjectsSectionKeys.PackageReferences, ProjectFileCreator.PackageReference.ParseJson),
            };
        }

        /// <summary>
        /// Parses the Visual Studio project metadata entries from the manifest. These
        /// are used when generating project files for a service.
        /// Sets the ProjectFileConfigurations member on exit with the collection of loaded
        /// configurations.
        /// </summary>
        /// <param name="document"></param>
        void LoadProjectConfigurations(JsonData document)
        {
            var projectConfigurations = new List<ProjectFileConfiguration>();

            var projectsNode = document[ProjectsSectionKeys.ProjectsKey];
            foreach (JsonData projectNode in projectsNode)
            {
                var projectTypeName = projectNode.SafeGetString(ProjectsSectionKeys.NameKey);
                var config = LoadProjectFileConfiguration(projectNode);

                var extraTestProjects = projectNode.SafeGet(ProjectsSectionKeys.ExtraTestProjects);
                if (extraTestProjects == null)
                {
                    config.ExtraTestProjects = new List<string>();
                }
                else
                {
                    config.ExtraTestProjects = (from object etp in extraTestProjects
                                                select etp.ToString()).ToList();
                }

                var sharedNugetFrameworks = projectNode.SafeGet(ProjectsSectionKeys.SharedNugetTargetFrameworksKey);
                config.SharedNugetTargetFrameworks = sharedNugetFrameworks == null ? new List<string>() : (from object bc in sharedNugetFrameworks select bc.ToString()).ToList();

                // This code assumes that the parent profile (project configuration) is defined in the manifest
                // before it's being referred by a sub profile.
                if (projectNode.PropertyNames.Contains(ProjectsSectionKeys.ParentProfile))
                {
                    var parentProfileName = projectNode[ProjectsSectionKeys.ParentProfile].ToString();
                    if (!string.IsNullOrEmpty(parentProfileName))
                    {
                        var parentProfile = projectConfigurations.SingleOrDefault(
                            p => p.Name.Equals(parentProfileName, StringComparison.InvariantCulture));
                        if (parentProfile == null)
                        {
                            throw new KeyNotFoundException(string.Format("Parent profile {0} referred by current profile {1} does not exist.",
                                parentProfile, config.Name));
                        }
                        config.ParentProfile = parentProfile;
                    }
                }

                projectConfigurations.Add(config);
            }

            ProjectFileConfigurations = projectConfigurations;
        }

        void LoadUnitTestProjectConfigurations(JsonData document)
        {
            IList<ProjectFileConfiguration> configuraitons = new List<ProjectFileConfiguration>();
            var projectsNode = document[ProjectsSectionKeys.UnitTestProjectsKey];
            foreach (JsonData projectNode in projectsNode)
            {
                var configuration = LoadProjectFileConfiguration(projectNode);
                configuraitons.Add(configuration);
            }

            UnitTestProjectFileConfigurations = configuraitons;
        }

        /// <summary>
        /// Finds the customizations file in \customizations as model.customizations.json if it's there
        /// </summary>
        /// <param name="model">The name of the model as defined in the _manifest</param>
        /// <returns>Full path to the customization if it exists, null if it wasn't found</returns>
        private static string DetermineCustomizationsPath(string serviceKey)
        {
            var files = Directory.GetFiles("customizations", serviceKey + ".customizations.json").OrderByDescending(x => x);
            return !files.Any() ? null : files.Single();
        }

        /// <summary>
        /// Loads a JsonData object for data in a given file.
        /// </summary>
        /// <param name="path">Path to the JSON file.</param>
        /// <returns>JsonData corresponding to JSON in the file.</returns>
        private static JsonData LoadJsonFromFile(string path)
        {
            JsonData data;
            using (var reader = new StreamReader(path))
                data = JsonMapper.ToObject(reader);
            return data;
        }

        private GenerationManifest()
        {

        }
    }
}
