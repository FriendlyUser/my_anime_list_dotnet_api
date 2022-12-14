/*
 * MyAnimeList API (beta ver.)
 *
 * MyAnimeList.net is the property of MyAnimeList Co.,Ltd. All Rights Reserved.  ## Versioning  There are multiple versions of the API. You can specify a version by including it in the request uri:  (During closed beta, version starts with '0.')  `https://api.myanimelist.net/v2`  The version is incremented if any backwards incompatible changes are introduced to the API.  Examples of backwards incompatible changes are belows:  - Removing existing endpoints. - Removing existing fields of API responses. - Changing mean of the existing fields.  On the other hand, belows are examples of backwards compatible changes:  - Adding new endpoints. - Adding new optional request parameters. - Adding new fields to existing API responses. - Changing the order of fields in existing API responses. - Changing the contents of fields that suffixed by `_formatted`.   ## Common formats  ### List / Pagination  ```json {   \"data\": [     {...},     {...},     ...   ],   \"paging\": {     \"previous\": \"https://xxx\",     \"next\": \"https://xxx\"   } } ```      ### Date / Time format  <table> <tr> <th>Format <th>Type <th>Sample <th>Description </tr>  <tr> <td>date-time <td>string <td>\"2015-03-02T06:03:11+00:00\"  <td>ISO 8601 </tr>      <tr> <td>date <td>string <td>\"2017-10-23\" or <br>\"2017-10\" or <br>\"2017\" <td> </tr>  <tr> <td>time <td>string <td>\"01:35\" <td> </tr>  </table>  ### Error format   ```json {   \"error\": \"invalid_token\"   \"message\": \"token is invalid\", } ```  ## Common parameters  ### Parameters for endpoints that return a list  | Name | Description | | - -- | - -- | | limit |  | | offset |  |  ### Choosing fields  By default, the API doesn’t return all fields.  You can choose the fields that you want returned with the `fields` parameter.  Example:  ``` fields=synopsis,my_list_status{priority,comments} ```  ### Not Safe For Work  By default, some APIs don’t return nsfw content.  You can control this behavior with the `nsfw` parameter.  | Name | Description | | - -- | - -- | | nsfw | `true` or `false` |   ## Common status codes  | Status code | Error code | Description | | - -- - | - -- - | - -- - | | 400 Bad Request | - | Invalid Parameters | | 401 Unauthorized | invalid_token | Expired access tokens, Invalid access tokens, etc. | | 403 Forbidden | - | DoS detected etc. | | 404 Not Found | - | |  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing UserAllOfAnimeStatistics
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserAllOfAnimeStatisticsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserAllOfAnimeStatistics
        //private UserAllOfAnimeStatistics instance;

        public UserAllOfAnimeStatisticsTests()
        {
            // TODO uncomment below to create an instance of UserAllOfAnimeStatistics
            //instance = new UserAllOfAnimeStatistics();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserAllOfAnimeStatistics
        /// </summary>
        [Fact]
        public void UserAllOfAnimeStatisticsInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserAllOfAnimeStatistics
            //Assert.IsType<UserAllOfAnimeStatistics>(instance);
        }


        /// <summary>
        /// Test the property 'NumItemsWatching'
        /// </summary>
        [Fact]
        public void NumItemsWatchingTest()
        {
            // TODO unit test for the property 'NumItemsWatching'
        }
        /// <summary>
        /// Test the property 'NumItemsCompleted'
        /// </summary>
        [Fact]
        public void NumItemsCompletedTest()
        {
            // TODO unit test for the property 'NumItemsCompleted'
        }
        /// <summary>
        /// Test the property 'NumItemsOnHold'
        /// </summary>
        [Fact]
        public void NumItemsOnHoldTest()
        {
            // TODO unit test for the property 'NumItemsOnHold'
        }
        /// <summary>
        /// Test the property 'NumItemsDropped'
        /// </summary>
        [Fact]
        public void NumItemsDroppedTest()
        {
            // TODO unit test for the property 'NumItemsDropped'
        }
        /// <summary>
        /// Test the property 'NumItemsPlanToWatch'
        /// </summary>
        [Fact]
        public void NumItemsPlanToWatchTest()
        {
            // TODO unit test for the property 'NumItemsPlanToWatch'
        }
        /// <summary>
        /// Test the property 'NumItems'
        /// </summary>
        [Fact]
        public void NumItemsTest()
        {
            // TODO unit test for the property 'NumItems'
        }
        /// <summary>
        /// Test the property 'NumDaysWatched'
        /// </summary>
        [Fact]
        public void NumDaysWatchedTest()
        {
            // TODO unit test for the property 'NumDaysWatched'
        }
        /// <summary>
        /// Test the property 'NumDaysWatching'
        /// </summary>
        [Fact]
        public void NumDaysWatchingTest()
        {
            // TODO unit test for the property 'NumDaysWatching'
        }
        /// <summary>
        /// Test the property 'NumDaysCompleted'
        /// </summary>
        [Fact]
        public void NumDaysCompletedTest()
        {
            // TODO unit test for the property 'NumDaysCompleted'
        }
        /// <summary>
        /// Test the property 'NumDaysOnHold'
        /// </summary>
        [Fact]
        public void NumDaysOnHoldTest()
        {
            // TODO unit test for the property 'NumDaysOnHold'
        }
        /// <summary>
        /// Test the property 'NumDaysDropped'
        /// </summary>
        [Fact]
        public void NumDaysDroppedTest()
        {
            // TODO unit test for the property 'NumDaysDropped'
        }
        /// <summary>
        /// Test the property 'NumDays'
        /// </summary>
        [Fact]
        public void NumDaysTest()
        {
            // TODO unit test for the property 'NumDays'
        }
        /// <summary>
        /// Test the property 'NumEpisodes'
        /// </summary>
        [Fact]
        public void NumEpisodesTest()
        {
            // TODO unit test for the property 'NumEpisodes'
        }
        /// <summary>
        /// Test the property 'NumTimesRewatched'
        /// </summary>
        [Fact]
        public void NumTimesRewatchedTest()
        {
            // TODO unit test for the property 'NumTimesRewatched'
        }
        /// <summary>
        /// Test the property 'MeanScore'
        /// </summary>
        [Fact]
        public void MeanScoreTest()
        {
            // TODO unit test for the property 'MeanScore'
        }

    }

}
