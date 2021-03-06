﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.PipelineCore;
using Microsoft.AspNet.Routing;
using Xunit;

namespace System.Web.Http
{
    public class InternalServerErrorResultTest
    {
        [Fact]
        public async Task InternalServerErrorResult_SetsStatusCode()
        {
            // Arrange
            var context = new ActionContext(new RouteContext(new DefaultHttpContext()), new ActionDescriptor());
            var result = new InternalServerErrorResult();

            // Act
            await result.ExecuteResultAsync(context);

            // Assert
            Assert.Equal(500, context.HttpContext.Response.StatusCode);
        }
    }
}
