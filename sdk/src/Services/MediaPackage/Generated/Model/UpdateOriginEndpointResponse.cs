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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// This is the response object from the UpdateOriginEndpoint operation.
    /// </summary>
    public partial class UpdateOriginEndpointResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _channelId;
        private DashPackage _dashPackage;
        private string _description;
        private HlsPackage _hlsPackage;
        private string _id;
        private string _manifestName;
        private MssPackage _mssPackage;
        private int? _startoverWindowSeconds;
        private int? _timeDelaySeconds;
        private string _url;
        private List<string> _whitelist = new List<string>();

        /// <summary>
        /// Gets and sets the property Arn. The Amazon Resource Name (ARN) assigned to the OriginEndpoint.
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelId. The ID of the Channel the OriginEndpoint is
        /// associated with.
        /// </summary>
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property DashPackage.
        /// </summary>
        public DashPackage DashPackage
        {
            get { return this._dashPackage; }
            set { this._dashPackage = value; }
        }

        // Check to see if DashPackage property is set
        internal bool IsSetDashPackage()
        {
            return this._dashPackage != null;
        }

        /// <summary>
        /// Gets and sets the property Description. A short text description of the OriginEndpoint.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property HlsPackage.
        /// </summary>
        public HlsPackage HlsPackage
        {
            get { return this._hlsPackage; }
            set { this._hlsPackage = value; }
        }

        // Check to see if HlsPackage property is set
        internal bool IsSetHlsPackage()
        {
            return this._hlsPackage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The ID of the OriginEndpoint.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestName. A short string appended to the end of the
        /// OriginEndpoint URL.
        /// </summary>
        public string ManifestName
        {
            get { return this._manifestName; }
            set { this._manifestName = value; }
        }

        // Check to see if ManifestName property is set
        internal bool IsSetManifestName()
        {
            return this._manifestName != null;
        }

        /// <summary>
        /// Gets and sets the property MssPackage.
        /// </summary>
        public MssPackage MssPackage
        {
            get { return this._mssPackage; }
            set { this._mssPackage = value; }
        }

        // Check to see if MssPackage property is set
        internal bool IsSetMssPackage()
        {
            return this._mssPackage != null;
        }

        /// <summary>
        /// Gets and sets the property StartoverWindowSeconds. Maximum duration (seconds) of content
        /// to retain for startover playback.If not specified, startover playback will be disabled
        /// for the OriginEndpoint.
        /// </summary>
        public int StartoverWindowSeconds
        {
            get { return this._startoverWindowSeconds.GetValueOrDefault(); }
            set { this._startoverWindowSeconds = value; }
        }

        // Check to see if StartoverWindowSeconds property is set
        internal bool IsSetStartoverWindowSeconds()
        {
            return this._startoverWindowSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeDelaySeconds. Amount of delay (seconds) to enforce
        /// on the playback of live content.If not specified, there will be no time delay in effect
        /// for the OriginEndpoint.
        /// </summary>
        public int TimeDelaySeconds
        {
            get { return this._timeDelaySeconds.GetValueOrDefault(); }
            set { this._timeDelaySeconds = value; }
        }

        // Check to see if TimeDelaySeconds property is set
        internal bool IsSetTimeDelaySeconds()
        {
            return this._timeDelaySeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Url. The URL of the packaged OriginEndpoint for consumption.
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property Whitelist. A list of source IP CIDR blocks that will be
        /// allowed to access the OriginEndpoint.
        /// </summary>
        public List<string> Whitelist
        {
            get { return this._whitelist; }
            set { this._whitelist = value; }
        }

        // Check to see if Whitelist property is set
        internal bool IsSetWhitelist()
        {
            return this._whitelist != null && this._whitelist.Count > 0; 
        }

    }
}