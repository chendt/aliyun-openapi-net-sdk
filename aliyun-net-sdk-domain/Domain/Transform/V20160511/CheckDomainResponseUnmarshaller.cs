/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Domain.Model.V20160511;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class CheckDomainResponseUnmarshaller
    {
        public static CheckDomainResponse Unmarshall(UnmarshallerContext context)
        {
			CheckDomainResponse checkDomainResponse = new CheckDomainResponse();

			checkDomainResponse.HttpResponse = context.HttpResponse;
			checkDomainResponse.RequestId = context.StringValue("CheckDomain.RequestId");
			checkDomainResponse.Name = context.StringValue("CheckDomain.Name");
			checkDomainResponse.Avail = context.IntegerValue("CheckDomain.Avail");
			checkDomainResponse.Reason = context.StringValue("CheckDomain.Reason");
			checkDomainResponse.FeeCurrency = context.StringValue("CheckDomain.FeeCurrency");
			checkDomainResponse.FeePeriod = context.IntegerValue("CheckDomain.FeePeriod");
			checkDomainResponse.FeeFee = context.StringValue("CheckDomain.FeeFee");
			checkDomainResponse.RmbFee = context.StringValue("CheckDomain.RmbFee");
			checkDomainResponse.FeeCommand = context.StringValue("CheckDomain.FeeCommand");
        
			return checkDomainResponse;
        }
    }
}