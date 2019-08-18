﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Marshallers
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class JsonRPCRequestMarshaller : JsonRPCStructureMarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	AddLicenseHeader();

	AddCommonUsingStatements();

            
            #line default
            #line hidden
            this.Write("using ThirdParty.Json.LitJson;\r\n\r\nnamespace ");
            
            #line 13 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n\t/// <summary>\r\n\t/// ");
            
            #line 16 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write(" Request Marshaller\r\n\t/// </summary>       \r\n\tpublic class ");
            
            #line 18 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("RequestMarshaller : IMarshaller<IRequest, ");
            
            #line 18 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write(@"Request> , IMarshaller<IRequest,AmazonWebServiceRequest>
	{
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name=""input""></param>
        /// <returns></returns>
		public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((");
            
            #line 27 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("Request)input);\r\n        }\r\n\r\n        /// <summary>\r\n        /// Marshaller the r" +
                    "equest object to the HTTP request.\r\n        /// </summary>  \r\n        /// <param" +
                    " name=\"publicRequest\"></param>\r\n        /// <returns></returns>\r\n\t\tpublic IReque" +
                    "st Marshall(");
            
            #line 35 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("Request publicRequest)\r\n\t\t{\r\n\t\t\tIRequest request = new DefaultRequest(publicReque" +
                    "st, \"");
            
            #line 37 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\");\r\n");
            
            #line 38 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
 if(!string.IsNullOrEmpty(this.Config.ServiceModel.TargetPrefix))
	{
            
            #line default
            #line hidden
            this.Write("\t\t\tstring target = \"");
            
            #line 40 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.TargetPrefix));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 40 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\trequest.Headers[\"X-Amz-Target\"] = target;\r\n");
            
            #line 42 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	}
	if(this.Operation.HttpMethod != "GET" && this.Operation.HttpMethod != "DELETE")
	{
		if(this.Config.ServiceModel.Type != ServiceType.Rest_Json)
		{

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.Headers[\"Content-Type\"] = \"application/x-amz-json-");
            
            #line 49 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.JsonVersion));
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 50 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}
		else
		{

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.Headers[\"Content-Type\"] = \"application/json\";\r\n");
            
            #line 56 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}
	}

            
            #line default
            #line hidden
            this.Write("            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = \"");
            
            #line 60 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.APIVersion));
            
            #line default
            #line hidden
            this.Write("\";            \r\n\t\t\trequest.HttpMethod = \"");
            
            #line 61 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.HttpMethod));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n");
            
            #line 63 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	var requestStructure = this.Operation.RequestStructure;
	
    // Generates code to add members of the request to the request being created by the marshaller
	ProcessRequestUri(this.Operation);

	if (this.Config.ServiceModel.Type == ServiceType.Rest_Json)
	{
		ProcessUriMembers("publicRequest", this.Operation);		
		ProcessQueryStringMembers("publicRequest", this.Operation);
	}

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.ResourcePath = \"");
            
            #line 75 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.RequestUri));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\trequest.MarshallerVersion = ");
            
            #line 76 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MarshallerVersion));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 77 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
  

    var payload= this.Operation.RequestPayloadMember;
    var shouldMarshallPayload = (payload != null && !payload.IsMemoryStream);
	// Process any members which are marshalled as part of the request body
	if(this.Operation.RequestHasBodyMembers || shouldMarshallPayload)
	{

            
            #line default
            #line hidden
            this.Write("\t\t\tusing (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCultu" +
                    "re))\r\n\t\t\t{\r\n\t\t\t\tJsonWriter writer = new JsonWriter(stringWriter);\r\n");
            
            #line 88 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
		
		if(shouldMarshallPayload)	
		{

            
            #line default
            #line hidden
            this.Write("\t\t\t\tvar context = new JsonMarshallerContext(request, writer);\r\n");
            
            #line 93 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
		
			ProcessStructure(0, "publicRequest." + this.Operation.RequestPayloadMember.PropertyName, this.Operation.RequestPayloadMember.Shape);
		}
		else
		{

            
            #line default
            #line hidden
            this.Write("\t\t\t\twriter.WriteObjectStart();\r\n\t\t\t\tvar context = new JsonMarshallerContext(reque" +
                    "st, writer);\r\n");
            
            #line 101 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
		
			ProcessMembers(1, "publicRequest", this.Operation.RequestBodyMembers);

            
            #line default
            #line hidden
            this.Write("\t\t\r\n\t\t\t\twriter.WriteObjectEnd();\r\n");
            
            #line 106 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}

            
            #line default
            #line hidden
            this.Write("\t\t\t\tstring snippet = stringWriter.ToString();\r\n\t\t\t\trequest.Content = System.Text." +
                    "Encoding.UTF8.GetBytes(snippet);\r\n\t\t\t}\r\n\r\n");
            
            #line 113 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	}
    else if (payload != null)
    {

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.ContentStream =  publicRequest.");
            
            #line 118 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.PropertyName));
            
            #line default
            #line hidden
            this.Write(" ?? new MemoryStream();\r\n");
            
            #line 119 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
		
		var requiresLength = payload.RequiresLength;		
		if(!requiresLength && payload.IsStreaming && this.Operation.AuthType == OperationAuthType.V4UnsignedBody)
		{

            
            #line default
            #line hidden
            this.Write(@"			if(request.ContentStream.CanSeek)
			{
				request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =  
					request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
			}
			else
			{
				request.Headers[Amazon.Util.HeaderKeys.TransferEncodingHeader] = ""chunked"";
			}
");
            
            #line 133 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}
		else
		{
			if(payload.IsStreaming && requiresLength)
			{

            
            #line default
            #line hidden
            this.Write("\t\t\tif(!request.ContentStream.CanSeek)\r\n\t\t\t{\r\n\t\t\t\tthrow new System.InvalidOperatio" +
                    "nException(\"Cannot determine stream length for the payload when content-length i" +
                    "s required.\");\r\n\t\t\t}\r\n");
            
            #line 144 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

			}

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =  \r\n\t\t\t\trequest.C" +
                    "ontentStream.Length.ToString(CultureInfo.InvariantCulture);\r\n");
            
            #line 149 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}		

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = \"binary/octet-stre" +
                    "am\";\r\n");
            
            #line 153 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

    }
	else if (this.Config.ServiceModel.Type == ServiceType.Json)
	{

            
            #line default
            #line hidden
            this.Write("            request.Content = System.Text.Encoding.UTF8.GetBytes(\"{}\");\r\n");
            
            #line 159 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	}

	if (this.Config.ServiceModel.Type == ServiceType.Rest_Json)
	{
		ProcessHeaderMembers("publicRequest", this.Operation.RequestHeaderMembers);		
	}

	// If there aren't any members that are marshalled as part of the body or streamed	
	if(this.Operation.UseQueryString)
	{

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.UseQueryString = true;\r\n");
            
            #line 172 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
	}

	if(!string.IsNullOrEmpty(this.Operation.EndpointHostPrefix))
	{
		ProcessEndpointHostPrefixMembers("publicRequest", this.Operation);
	}

            
            #line default
            #line hidden
            this.Write("\r\n\t\t\treturn request;\r\n\t\t}\r\n");
            
            #line 182 "C:\Dev\Worktrees\UrlSegments\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
				
		this.AddRequestSingletonMethod();

            
            #line default
            #line hidden
            this.Write("\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
