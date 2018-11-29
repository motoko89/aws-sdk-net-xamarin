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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.MediaStoreData.Model;
using Amazon.MediaStoreData.Model.Internal.MarshallTransformations;
using Amazon.MediaStoreData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MediaStoreData
{
    /// <summary>
    /// Implementation for accessing MediaStoreData
    ///
    /// An AWS Elemental MediaStore asset is an object, similar to an object in the Amazon
    /// S3 service. Objects are the fundamental entities that are stored in AWS Elemental
    /// MediaStore.
    /// </summary>
    public partial class AmazonMediaStoreDataClient : AmazonServiceClient, IAmazonMediaStoreData
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaStoreDataMetadata();

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  DeleteObject


        /// <summary>
        /// Deletes an object at the specified path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.ObjectNotFoundException">
        /// Could not perform an operation on an object that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var marshaller = DeleteObjectRequestMarshaller.Instance;
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectRequest,DeleteObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteObjectRequestMarshaller.Instance;
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectRequest,DeleteObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeObject


        /// <summary>
        /// Gets the headers for an object at the specified path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObject service method.</param>
        /// 
        /// <returns>The response from the DescribeObject service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.ObjectNotFoundException">
        /// Could not perform an operation on an object that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/DescribeObject">REST API Reference for DescribeObject Operation</seealso>
        public virtual DescribeObjectResponse DescribeObject(DescribeObjectRequest request)
        {
            var marshaller = DescribeObjectRequestMarshaller.Instance;
            var unmarshaller = DescribeObjectResponseUnmarshaller.Instance;

            return Invoke<DescribeObjectRequest,DescribeObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/DescribeObject">REST API Reference for DescribeObject Operation</seealso>
        public virtual Task<DescribeObjectResponse> DescribeObjectAsync(DescribeObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeObjectRequestMarshaller.Instance;
            var unmarshaller = DescribeObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeObjectRequest,DescribeObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetObject


        /// <summary>
        /// Downloads the object at the specified path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObject service method.</param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.ObjectNotFoundException">
        /// Could not perform an operation on an object that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.RequestedRangeNotSatisfiableException">
        /// The requested content range is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/GetObject">REST API Reference for GetObject Operation</seealso>
        public virtual GetObjectResponse GetObject(GetObjectRequest request)
        {
            var marshaller = GetObjectRequestMarshaller.Instance;
            var unmarshaller = GetObjectResponseUnmarshaller.Instance;

            return Invoke<GetObjectRequest,GetObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/GetObject">REST API Reference for GetObject Operation</seealso>
        public virtual Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetObjectRequestMarshaller.Instance;
            var unmarshaller = GetObjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectRequest,GetObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListItems


        /// <summary>
        /// Provides a list of metadata entries about folders and objects in the specified folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListItems service method.</param>
        /// 
        /// <returns>The response from the ListItems service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/ListItems">REST API Reference for ListItems Operation</seealso>
        public virtual ListItemsResponse ListItems(ListItemsRequest request)
        {
            var marshaller = ListItemsRequestMarshaller.Instance;
            var unmarshaller = ListItemsResponseUnmarshaller.Instance;

            return Invoke<ListItemsRequest,ListItemsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListItems operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/ListItems">REST API Reference for ListItems Operation</seealso>
        public virtual Task<ListItemsResponse> ListItemsAsync(ListItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListItemsRequestMarshaller.Instance;
            var unmarshaller = ListItemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListItemsRequest,ListItemsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutObject


        /// <summary>
        /// Uploads an object to the specified path. Object sizes are limited to 25 MB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObject service method.</param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by MediaStoreData.</returns>
        /// <exception cref="Amazon.MediaStoreData.Model.ContainerNotFoundException">
        /// The specified container was not found for the specified account.
        /// </exception>
        /// <exception cref="Amazon.MediaStoreData.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/PutObject">REST API Reference for PutObject Operation</seealso>
        public virtual PutObjectResponse PutObject(PutObjectRequest request)
        {
            var marshaller = PutObjectRequestMarshaller.Instance;
            var unmarshaller = PutObjectResponseUnmarshaller.Instance;

            return Invoke<PutObjectRequest,PutObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-data-2017-09-01/PutObject">REST API Reference for PutObject Operation</seealso>
        public virtual Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutObjectRequestMarshaller.Instance;
            var unmarshaller = PutObjectResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectRequest,PutObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}