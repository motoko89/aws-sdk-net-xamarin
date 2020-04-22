/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Elasticsearch;
using Amazon.Elasticsearch.Model;
using Amazon.Elasticsearch.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class ElasticsearchMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("es");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void AddTagsMarshallTest()
        {
            var operation = service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AddTags", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void AssociatePackageMarshallTest()
        {
            var operation = service_model.FindOperation("AssociatePackage");

            var request = InstantiateClassGenerator.Execute<AssociatePackageRequest>();
            var marshaller = new AssociatePackageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("AssociatePackage", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = AssociatePackageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AssociatePackageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void CancelElasticsearchServiceSoftwareUpdateMarshallTest()
        {
            var operation = service_model.FindOperation("CancelElasticsearchServiceSoftwareUpdate");

            var request = InstantiateClassGenerator.Execute<CancelElasticsearchServiceSoftwareUpdateRequest>();
            var marshaller = new CancelElasticsearchServiceSoftwareUpdateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CancelElasticsearchServiceSoftwareUpdate", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CancelElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CancelElasticsearchServiceSoftwareUpdateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void CreateElasticsearchDomainMarshallTest()
        {
            var operation = service_model.FindOperation("CreateElasticsearchDomain");

            var request = InstantiateClassGenerator.Execute<CreateElasticsearchDomainRequest>();
            var marshaller = new CreateElasticsearchDomainRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateElasticsearchDomain", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateElasticsearchDomainResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateElasticsearchDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void CreatePackageMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePackage");

            var request = InstantiateClassGenerator.Execute<CreatePackageRequest>();
            var marshaller = new CreatePackageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreatePackage", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreatePackageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreatePackageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DeleteElasticsearchDomainMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteElasticsearchDomain");

            var request = InstantiateClassGenerator.Execute<DeleteElasticsearchDomainRequest>();
            var marshaller = new DeleteElasticsearchDomainRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteElasticsearchDomain", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteElasticsearchDomainResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteElasticsearchDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DeleteElasticsearchServiceRoleMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteElasticsearchServiceRole");

            var request = InstantiateClassGenerator.Execute<DeleteElasticsearchServiceRoleRequest>();
            var marshaller = new DeleteElasticsearchServiceRoleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteElasticsearchServiceRole", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DeletePackageMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePackage");

            var request = InstantiateClassGenerator.Execute<DeletePackageRequest>();
            var marshaller = new DeletePackageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeletePackage", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeletePackageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeletePackageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DescribeElasticsearchDomainMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeElasticsearchDomain");

            var request = InstantiateClassGenerator.Execute<DescribeElasticsearchDomainRequest>();
            var marshaller = new DescribeElasticsearchDomainRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeElasticsearchDomain", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeElasticsearchDomainResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeElasticsearchDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DescribeElasticsearchDomainConfigMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeElasticsearchDomainConfig");

            var request = InstantiateClassGenerator.Execute<DescribeElasticsearchDomainConfigRequest>();
            var marshaller = new DescribeElasticsearchDomainConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeElasticsearchDomainConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeElasticsearchDomainConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeElasticsearchDomainConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DescribeElasticsearchDomainsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeElasticsearchDomains");

            var request = InstantiateClassGenerator.Execute<DescribeElasticsearchDomainsRequest>();
            var marshaller = new DescribeElasticsearchDomainsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeElasticsearchDomains", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeElasticsearchDomainsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeElasticsearchDomainsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DescribeElasticsearchInstanceTypeLimitsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeElasticsearchInstanceTypeLimits");

            var request = InstantiateClassGenerator.Execute<DescribeElasticsearchInstanceTypeLimitsRequest>();
            var marshaller = new DescribeElasticsearchInstanceTypeLimitsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeElasticsearchInstanceTypeLimits", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeElasticsearchInstanceTypeLimitsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeElasticsearchInstanceTypeLimitsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DescribePackagesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePackages");

            var request = InstantiateClassGenerator.Execute<DescribePackagesRequest>();
            var marshaller = new DescribePackagesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribePackages", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribePackagesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribePackagesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DescribeReservedElasticsearchInstanceOfferingsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedElasticsearchInstanceOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeReservedElasticsearchInstanceOfferingsRequest>();
            var marshaller = new DescribeReservedElasticsearchInstanceOfferingsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeReservedElasticsearchInstanceOfferings", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeReservedElasticsearchInstanceOfferingsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeReservedElasticsearchInstanceOfferingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DescribeReservedElasticsearchInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedElasticsearchInstances");

            var request = InstantiateClassGenerator.Execute<DescribeReservedElasticsearchInstancesRequest>();
            var marshaller = new DescribeReservedElasticsearchInstancesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeReservedElasticsearchInstances", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeReservedElasticsearchInstancesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeReservedElasticsearchInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void DissociatePackageMarshallTest()
        {
            var operation = service_model.FindOperation("DissociatePackage");

            var request = InstantiateClassGenerator.Execute<DissociatePackageRequest>();
            var marshaller = new DissociatePackageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DissociatePackage", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DissociatePackageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DissociatePackageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void GetCompatibleElasticsearchVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("GetCompatibleElasticsearchVersions");

            var request = InstantiateClassGenerator.Execute<GetCompatibleElasticsearchVersionsRequest>();
            var marshaller = new GetCompatibleElasticsearchVersionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetCompatibleElasticsearchVersions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetCompatibleElasticsearchVersionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetCompatibleElasticsearchVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void GetUpgradeHistoryMarshallTest()
        {
            var operation = service_model.FindOperation("GetUpgradeHistory");

            var request = InstantiateClassGenerator.Execute<GetUpgradeHistoryRequest>();
            var marshaller = new GetUpgradeHistoryRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetUpgradeHistory", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetUpgradeHistoryResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetUpgradeHistoryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void GetUpgradeStatusMarshallTest()
        {
            var operation = service_model.FindOperation("GetUpgradeStatus");

            var request = InstantiateClassGenerator.Execute<GetUpgradeStatusRequest>();
            var marshaller = new GetUpgradeStatusRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetUpgradeStatus", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetUpgradeStatusResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetUpgradeStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void ListDomainNamesMarshallTest()
        {
            var operation = service_model.FindOperation("ListDomainNames");

            var request = InstantiateClassGenerator.Execute<ListDomainNamesRequest>();
            var marshaller = new ListDomainNamesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDomainNames", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListDomainNamesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDomainNamesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void ListDomainsForPackageMarshallTest()
        {
            var operation = service_model.FindOperation("ListDomainsForPackage");

            var request = InstantiateClassGenerator.Execute<ListDomainsForPackageRequest>();
            var marshaller = new ListDomainsForPackageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDomainsForPackage", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListDomainsForPackageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDomainsForPackageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void ListElasticsearchInstanceTypesMarshallTest()
        {
            var operation = service_model.FindOperation("ListElasticsearchInstanceTypes");

            var request = InstantiateClassGenerator.Execute<ListElasticsearchInstanceTypesRequest>();
            var marshaller = new ListElasticsearchInstanceTypesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListElasticsearchInstanceTypes", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListElasticsearchInstanceTypesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListElasticsearchInstanceTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void ListElasticsearchVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListElasticsearchVersions");

            var request = InstantiateClassGenerator.Execute<ListElasticsearchVersionsRequest>();
            var marshaller = new ListElasticsearchVersionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListElasticsearchVersions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListElasticsearchVersionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListElasticsearchVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void ListPackagesForDomainMarshallTest()
        {
            var operation = service_model.FindOperation("ListPackagesForDomain");

            var request = InstantiateClassGenerator.Execute<ListPackagesForDomainRequest>();
            var marshaller = new ListPackagesForDomainRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListPackagesForDomain", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListPackagesForDomainResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListPackagesForDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void ListTagsMarshallTest()
        {
            var operation = service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListTags", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListTagsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTagsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void PurchaseReservedElasticsearchInstanceOfferingMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedElasticsearchInstanceOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedElasticsearchInstanceOfferingRequest>();
            var marshaller = new PurchaseReservedElasticsearchInstanceOfferingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PurchaseReservedElasticsearchInstanceOffering", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PurchaseReservedElasticsearchInstanceOfferingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PurchaseReservedElasticsearchInstanceOfferingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void RemoveTagsMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RemoveTags", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void StartElasticsearchServiceSoftwareUpdateMarshallTest()
        {
            var operation = service_model.FindOperation("StartElasticsearchServiceSoftwareUpdate");

            var request = InstantiateClassGenerator.Execute<StartElasticsearchServiceSoftwareUpdateRequest>();
            var marshaller = new StartElasticsearchServiceSoftwareUpdateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartElasticsearchServiceSoftwareUpdate", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = StartElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as StartElasticsearchServiceSoftwareUpdateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void UpdateElasticsearchDomainConfigMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateElasticsearchDomainConfig");

            var request = InstantiateClassGenerator.Execute<UpdateElasticsearchDomainConfigRequest>();
            var marshaller = new UpdateElasticsearchDomainConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateElasticsearchDomainConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateElasticsearchDomainConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateElasticsearchDomainConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Elasticsearch")]
        public void UpgradeElasticsearchDomainMarshallTest()
        {
            var operation = service_model.FindOperation("UpgradeElasticsearchDomain");

            var request = InstantiateClassGenerator.Execute<UpgradeElasticsearchDomainRequest>();
            var marshaller = new UpgradeElasticsearchDomainRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpgradeElasticsearchDomain", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpgradeElasticsearchDomainResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpgradeElasticsearchDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}