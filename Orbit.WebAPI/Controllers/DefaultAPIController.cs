using System;
using System.ComponentModel.DataAnnotations;
using APIMDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace Orbit.WebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultAPIController : ControllerBase
    {
        
        //Demo Code Start

        /// <summary>
        /// AddAttachment
        /// </summary>
        /// <remarks>AddAttachment</remarks>
        /// <param name="body"></param>
        /// <response code="0">default</response>
        [HttpPost]
        [Route("//api/data/v9.0/annotations")]
        //[ValidateModelState]
        public virtual IActionResult AddAttachment([FromBody] Body4 body)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Object));

            string exampleJson = null;
            exampleJson = "\"\"";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// AddUserToAccessTeamTemplate
        /// </summary>
        /// <remarks>AddUserToAccessTeamTemplate</remarks>
        /// <param name="userid"></param>
        /// <param name="body"></param>
        /// <response code="0">default</response>
        [HttpPost]
        [Route("//api/data/v9.0/systemusers({userid})/Microsoft.Dynamics.CRM.AddUserToRecordTeam")]
        public virtual IActionResult AddUserToAccessTeamTemplate([FromRoute][Required] string userid, [FromBody] Body1 body)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Object));

            string exampleJson = null;
            exampleJson = "\"\"";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }



        /// <summary>
        /// Get GTMEntries
        /// </summary>
        /// <remarks>Get GTMEntries</remarks>
        /// <param name="select"></param>
        /// <param name="expand"></param>
        /// <param name="orderby"></param>
        /// <param name="top"></param>
        /// <param name="filter"></param>
        /// <param name="prefer"></param>
        /// <response code="0">default</response>
        [HttpGet]
        [Route("/cat_gtmentries")]
        public virtual IActionResult CatGtmentries([FromQuery] string select, [FromQuery] string expand, [FromQuery] string orderby, [FromQuery] int? top, [FromQuery] string filter, [FromHeader] string prefer)
        {
           
            string responseJson = DataService.CatGtmentriesJson();
            var response = responseJson != null
            ? JsonConvert.DeserializeObject<InlineResponseDefault>(responseJson)
            : default(InlineResponseDefault);
            
            return new ObjectResult(response);
        }

        /// <summary>
        /// CreateAndAssociate
        /// </summary>
        /// <remarks>CreateAndAssociate</remarks>
        /// <param name="entityName"></param>
        /// <param name="body"></param>
        /// <response code="0">default</response>
        [HttpPost]
        [Route("//api/data/v9.0/{entityName}")]
        public virtual IActionResult CreateAndAssociate([FromRoute][Required] string entityName, [FromBody] Object body)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Object));

            string exampleJson = null;
            exampleJson = "\"\"";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create BPF Instance
        /// </summary>
        /// <remarks>Create BPF Instance</remarks>
        /// <param name="body"></param>
        /// <response code="0">default</response>
        [HttpPost]
        [Route("//api/data/v9.0/ORBIT_Initiative_Approval_Process")]
        public virtual IActionResult CreateBPFInstance([FromBody] Body body)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Object));

            string exampleJson = null;
            exampleJson = "\"\"";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// GetBPF
        /// </summary>
        /// <remarks>GetBPF</remarks>
        /// <param name="filter"></param>
        /// <param name="select"></param>
        /// <response code="0">default</response>
        [HttpGet]
        [Route("//contosodev.crm.dynamics.com/api/data/v9.0/workflows")]
        public virtual IActionResult GetBPF([FromQuery] string filter, [FromQuery] string select)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(InlineResponseDefault1));

            string exampleJson = null;
            exampleJson = "{\n  \"@odata.context\" : \"@odata.context\",\n  \"value\" : [ {\n    \"uniquename\" : \"uniquename\",\n    \"@odata.etag\" : \"@odata.etag\",\n    \"workflowid\" : \"workflowid\"\n  }, {\n    \"uniquename\" : \"uniquename\",\n    \"@odata.etag\" : \"@odata.etag\",\n    \"workflowid\" : \"workflowid\"\n  } ]\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponseDefault1>(exampleJson)
            : default(InlineResponseDefault1);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// GetBPFActivePath
        /// </summary>
        /// <remarks>GetBPFActivePath</remarks>
        /// <param name="processInstanceId"></param>
        /// <response code="0">default</response>
        [HttpGet]
        [Route("//api/data/v9.1/RetrieveActivePath(ProcessInstanceId={ProcessInstanceId})")]
        public virtual IActionResult GetBPFActivePath([FromRoute][Required] string processInstanceId)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(InlineResponseDefault2));

            string exampleJson = null;
            exampleJson = DataService.GetBPFActivePathJson();

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponseDefault2>(exampleJson)
            : default(InlineResponseDefault2);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// GetFileBase64String
        /// </summary>
        /// <remarks>GetFileBase64String</remarks>
        /// <param name="stringID"></param>
        /// <param name="select"></param>
        /// <param name="documentbody"></param>
        /// <response code="0">default</response>
        [HttpGet]
        [Route("//api/data/v9.0/annotations({stringID})")]
        public virtual IActionResult GetFileBase64String([FromRoute][Required] string stringID, [FromQuery] string select, [FromHeader] string documentbody)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Object));

            string exampleJson = null;
            exampleJson = "\"\"";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// GetOptionSets
        /// </summary>
        /// <remarks>GetOptionSets</remarks>
        /// <param name="select"></param>
        /// <param name="expand"></param>
        /// <response code="0">default</response>
        [HttpGet]
        [Route("//api/data/v9.0/EntityDefinitions(LogicalName='cat_gtmentry')/Attributes/Microsoft.Dynamics.CRM.PicklistAttributeMetadata")]
        public virtual IActionResult GetOptionSets([FromQuery] string select, [FromQuery] string expand)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(InlineResponseDefault6));

            string exampleJson = null;
            exampleJson = "{\n  \"@odata.context\" : \"@odata.context\",\n  \"value\" : [ {\n    \"LogicalName\" : \"LogicalName\",\n    \"MetadataId\" : \"MetadataId\",\n    \"OptionSet\" : {\n      \"Options\" : [ {\n        \"ParentValues\" : [ \"\", \"\" ],\n        \"Description\" : {\n          \"LocalizedLabels\" : [ {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          }, {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          } ],\n          \"UserLocalizedLabel\" : \"UserLocalizedLabel\"\n        },\n        \"Color\" : \"Color\",\n        \"MetadataId\" : \"MetadataId\",\n        \"Value\" : 1,\n        \"Label\" : {\n          \"LocalizedLabels\" : [ {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          }, {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          } ],\n          \"UserLocalizedLabel\" : {\n            \"LanguageCode\" : 6,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          }\n        },\n        \"IsManaged\" : true,\n        \"ExternalValue\" : \"ExternalValue\",\n        \"HasChanged\" : \"HasChanged\"\n      }, {\n        \"ParentValues\" : [ \"\", \"\" ],\n        \"Description\" : {\n          \"LocalizedLabels\" : [ {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          }, {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          } ],\n          \"UserLocalizedLabel\" : \"UserLocalizedLabel\"\n        },\n        \"Color\" : \"Color\",\n        \"MetadataId\" : \"MetadataId\",\n        \"Value\" : 1,\n        \"Label\" : {\n          \"LocalizedLabels\" : [ {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          }, {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          } ],\n          \"UserLocalizedLabel\" : {\n            \"LanguageCode\" : 6,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          }\n        },\n        \"IsManaged\" : true,\n        \"ExternalValue\" : \"ExternalValue\",\n        \"HasChanged\" : \"HasChanged\"\n      } ],\n      \"IntroducedVersion\" : \"IntroducedVersion\",\n      \"Description\" : {\n        \"LocalizedLabels\" : [ {\n          \"LanguageCode\" : 0,\n          \"MetadataId\" : \"MetadataId\",\n          \"Label\" : \"Label\",\n          \"IsManaged\" : true,\n          \"HasChanged\" : \"HasChanged\"\n        }, {\n          \"LanguageCode\" : 0,\n          \"MetadataId\" : \"MetadataId\",\n          \"Label\" : \"Label\",\n          \"IsManaged\" : true,\n          \"HasChanged\" : \"HasChanged\"\n        } ],\n        \"UserLocalizedLabel\" : {\n          \"LanguageCode\" : 6,\n          \"MetadataId\" : \"MetadataId\",\n          \"Label\" : \"Label\",\n          \"IsManaged\" : true,\n          \"HasChanged\" : \"HasChanged\"\n        }\n      },\n      \"ExternalTypeName\" : \"ExternalTypeName\",\n      \"MetadataId\" : \"MetadataId\",\n      \"IsCustomOptionSet\" : true,\n      \"Name\" : \"Name\",\n      \"ParentOptionSetName\" : \"ParentOptionSetName\",\n      \"DisplayName\" : {\n        \"LocalizedLabels\" : [ {\n          \"LanguageCode\" : 0,\n          \"MetadataId\" : \"MetadataId\",\n          \"Label\" : \"Label\",\n          \"IsManaged\" : true,\n          \"HasChanged\" : \"HasChanged\"\n        }, {\n          \"LanguageCode\" : 0,\n          \"MetadataId\" : \"MetadataId\",\n          \"Label\" : \"Label\",\n          \"IsManaged\" : true,\n          \"HasChanged\" : \"HasChanged\"\n        } ],\n        \"UserLocalizedLabel\" : {\n          \"LanguageCode\" : 6,\n          \"MetadataId\" : \"MetadataId\",\n          \"Label\" : \"Label\",\n          \"IsManaged\" : true,\n          \"HasChanged\" : \"HasChanged\"\n        }\n      },\n      \"IsManaged\" : true,\n      \"OptionSetType\" : \"OptionSetType\",\n      \"HasChanged\" : \"HasChanged\",\n      \"IsGlobal\" : true,\n      \"IsCustomizable\" : {\n        \"CanBeChanged\" : true,\n        \"Value\" : true,\n        \"ManagedPropertyLogicalName\" : \"ManagedPropertyLogicalName\"\n      }\n    }\n  }, {\n    \"LogicalName\" : \"LogicalName\",\n    \"MetadataId\" : \"MetadataId\",\n    \"OptionSet\" : {\n      \"Options\" : [ {\n        \"ParentValues\" : [ \"\", \"\" ],\n        \"Description\" : {\n          \"LocalizedLabels\" : [ {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          }, {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          } ],\n          \"UserLocalizedLabel\" : \"UserLocalizedLabel\"\n        },\n        \"Color\" : \"Color\",\n        \"MetadataId\" : \"MetadataId\",\n        \"Value\" : 1,\n        \"Label\" : {\n          \"LocalizedLabels\" : [ {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          }, {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          } ],\n          \"UserLocalizedLabel\" : {\n            \"LanguageCode\" : 6,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          }\n        },\n        \"IsManaged\" : true,\n        \"ExternalValue\" : \"ExternalValue\",\n        \"HasChanged\" : \"HasChanged\"\n      }, {\n        \"ParentValues\" : [ \"\", \"\" ],\n        \"Description\" : {\n          \"LocalizedLabels\" : [ {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          }, {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          } ],\n          \"UserLocalizedLabel\" : \"UserLocalizedLabel\"\n        },\n        \"Color\" : \"Color\",\n        \"MetadataId\" : \"MetadataId\",\n        \"Value\" : 1,\n        \"Label\" : {\n          \"LocalizedLabels\" : [ {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          }, {\n            \"LanguageCode\" : 0,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          } ],\n          \"UserLocalizedLabel\" : {\n            \"LanguageCode\" : 6,\n            \"MetadataId\" : \"MetadataId\",\n            \"Label\" : \"Label\",\n            \"IsManaged\" : true,\n            \"HasChanged\" : \"HasChanged\"\n          }\n        },\n        \"IsManaged\" : true,\n        \"ExternalValue\" : \"ExternalValue\",\n        \"HasChanged\" : \"HasChanged\"\n      } ],\n      \"IntroducedVersion\" : \"IntroducedVersion\",\n      \"Description\" : {\n        \"LocalizedLabels\" : [ {\n          \"LanguageCode\" : 0,\n          \"MetadataId\" : \"MetadataId\",\n          \"Label\" : \"Label\",\n          \"IsManaged\" : true,\n          \"HasChanged\" : \"HasChanged\"\n        }, {\n          \"LanguageCode\" : 0,\n          \"MetadataId\" : \"MetadataId\",\n          \"Label\" : \"Label\",\n          \"IsManaged\" : true,\n          \"HasChanged\" : \"HasChanged\"\n        } ],\n        \"UserLocalizedLabel\" : {\n          \"LanguageCode\" : 6,\n          \"MetadataId\" : \"MetadataId\",\n          \"Label\" : \"Label\",\n          \"IsManaged\" : true,\n          \"HasChanged\" : \"HasChanged\"\n        }\n      },\n      \"ExternalTypeName\" : \"ExternalTypeName\",\n      \"MetadataId\" : \"MetadataId\",\n      \"IsCustomOptionSet\" : true,\n      \"Name\" : \"Name\",\n      \"ParentOptionSetName\" : \"ParentOptionSetName\",\n      \"DisplayName\" : {\n        \"LocalizedLabels\" : [ {\n          \"LanguageCode\" : 0,\n          \"MetadataId\" : \"MetadataId\",\n          \"Label\" : \"Label\",\n          \"IsManaged\" : true,\n          \"HasChanged\" : \"HasChanged\"\n        }, {\n          \"LanguageCode\" : 0,\n          \"MetadataId\" : \"MetadataId\",\n          \"Label\" : \"Label\",\n          \"IsManaged\" : true,\n          \"HasChanged\" : \"HasChanged\"\n        } ],\n        \"UserLocalizedLabel\" : {\n          \"LanguageCode\" : 6,\n          \"MetadataId\" : \"MetadataId\",\n          \"Label\" : \"Label\",\n          \"IsManaged\" : true,\n          \"HasChanged\" : \"HasChanged\"\n        }\n      },\n      \"IsManaged\" : true,\n      \"OptionSetType\" : \"OptionSetType\",\n      \"HasChanged\" : \"HasChanged\",\n      \"IsGlobal\" : true,\n      \"IsCustomizable\" : {\n        \"CanBeChanged\" : true,\n        \"Value\" : true,\n        \"ManagedPropertyLogicalName\" : \"ManagedPropertyLogicalName\"\n      }\n    }\n  } ]\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponseDefault6>(exampleJson)
            : default(InlineResponseDefault6);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// GetSingleOptionSet
        /// </summary>
        /// <remarks>GetSingleOptionSet</remarks>
        /// <param name="optionSetName"></param>
        /// <response code="0">default</response>
        [HttpGet]
        [Route("//api/data/v9.0/GlobalOptionSetDefinitions(Name='{OptionSetName}')")]
        public virtual IActionResult GetSingleOptionSet([FromRoute][Required] string optionSetName)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(InlineResponseDefault7));

            string exampleJson = null;
            exampleJson = "{\n  \"Options\" : [ {\n    \"ParentValues\" : [ \"\", \"\" ],\n    \"Description\" : {\n      \"LocalizedLabels\" : [ \"\", \"\" ],\n      \"UserLocalizedLabel\" : \"UserLocalizedLabel\"\n    },\n    \"Color\" : \"Color\",\n    \"MetadataId\" : \"MetadataId\",\n    \"Value\" : 0,\n    \"Label\" : {\n      \"LocalizedLabels\" : [ {\n        \"LanguageCode\" : 0,\n        \"MetadataId\" : \"MetadataId\",\n        \"Label\" : \"Label\",\n        \"IsManaged\" : true,\n        \"HasChanged\" : \"HasChanged\"\n      }, {\n        \"LanguageCode\" : 0,\n        \"MetadataId\" : \"MetadataId\",\n        \"Label\" : \"Label\",\n        \"IsManaged\" : true,\n        \"HasChanged\" : \"HasChanged\"\n      } ],\n      \"UserLocalizedLabel\" : {\n        \"LanguageCode\" : 6,\n        \"MetadataId\" : \"MetadataId\",\n        \"Label\" : \"Label\",\n        \"IsManaged\" : true,\n        \"HasChanged\" : \"HasChanged\"\n      }\n    },\n    \"IsManaged\" : true,\n    \"ExternalValue\" : \"ExternalValue\",\n    \"HasChanged\" : \"HasChanged\"\n  }, {\n    \"ParentValues\" : [ \"\", \"\" ],\n    \"Description\" : {\n      \"LocalizedLabels\" : [ \"\", \"\" ],\n      \"UserLocalizedLabel\" : \"UserLocalizedLabel\"\n    },\n    \"Color\" : \"Color\",\n    \"MetadataId\" : \"MetadataId\",\n    \"Value\" : 0,\n    \"Label\" : {\n      \"LocalizedLabels\" : [ {\n        \"LanguageCode\" : 0,\n        \"MetadataId\" : \"MetadataId\",\n        \"Label\" : \"Label\",\n        \"IsManaged\" : true,\n        \"HasChanged\" : \"HasChanged\"\n      }, {\n        \"LanguageCode\" : 0,\n        \"MetadataId\" : \"MetadataId\",\n        \"Label\" : \"Label\",\n        \"IsManaged\" : true,\n        \"HasChanged\" : \"HasChanged\"\n      } ],\n      \"UserLocalizedLabel\" : {\n        \"LanguageCode\" : 6,\n        \"MetadataId\" : \"MetadataId\",\n        \"Label\" : \"Label\",\n        \"IsManaged\" : true,\n        \"HasChanged\" : \"HasChanged\"\n      }\n    },\n    \"IsManaged\" : true,\n    \"ExternalValue\" : \"ExternalValue\",\n    \"HasChanged\" : \"HasChanged\"\n  } ],\n  \"IntroducedVersion\" : \"IntroducedVersion\",\n  \"Description\" : {\n    \"LocalizedLabels\" : [ {\n      \"LanguageCode\" : 0,\n      \"MetadataId\" : \"MetadataId\",\n      \"Label\" : \"Label\",\n      \"IsManaged\" : true,\n      \"HasChanged\" : \"HasChanged\"\n    }, {\n      \"LanguageCode\" : 0,\n      \"MetadataId\" : \"MetadataId\",\n      \"Label\" : \"Label\",\n      \"IsManaged\" : true,\n      \"HasChanged\" : \"HasChanged\"\n    } ],\n    \"UserLocalizedLabel\" : {\n      \"LanguageCode\" : 6,\n      \"MetadataId\" : \"MetadataId\",\n      \"Label\" : \"Label\",\n      \"IsManaged\" : true,\n      \"HasChanged\" : \"HasChanged\"\n    }\n  },\n  \"@odata.type\" : \"@odata.type\",\n  \"ExternalTypeName\" : \"ExternalTypeName\",\n  \"MetadataId\" : \"MetadataId\",\n  \"IsCustomOptionSet\" : true,\n  \"@odata.context\" : \"@odata.context\",\n  \"Name\" : \"Name\",\n  \"ParentOptionSetName\" : \"ParentOptionSetName\",\n  \"DisplayName\" : {\n    \"LocalizedLabels\" : [ {\n      \"LanguageCode\" : 0,\n      \"MetadataId\" : \"MetadataId\",\n      \"Label\" : \"Label\",\n      \"IsManaged\" : true,\n      \"HasChanged\" : \"HasChanged\"\n    }, {\n      \"LanguageCode\" : 0,\n      \"MetadataId\" : \"MetadataId\",\n      \"Label\" : \"Label\",\n      \"IsManaged\" : true,\n      \"HasChanged\" : \"HasChanged\"\n    } ],\n    \"UserLocalizedLabel\" : {\n      \"LanguageCode\" : 6,\n      \"MetadataId\" : \"MetadataId\",\n      \"Label\" : \"Label\",\n      \"IsManaged\" : true,\n      \"HasChanged\" : \"HasChanged\"\n    }\n  },\n  \"IsManaged\" : true,\n  \"OptionSetType\" : \"OptionSetType\",\n  \"HasChanged\" : \"HasChanged\",\n  \"IsGlobal\" : true,\n  \"IsCustomizable\" : {\n    \"CanBeChanged\" : true,\n    \"Value\" : true,\n    \"ManagedPropertyLogicalName\" : \"ManagedPropertyLogicalName\"\n  }\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponseDefault7>(exampleJson)
            : default(InlineResponseDefault7);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get User Record
        /// </summary>

        /// <param name="userID"></param>
        /// <response code="0">default</response>
        [HttpGet]
        [Route("//api/data/v9.1/systemusers({UserID})")]
        public virtual IActionResult GetUserRecord([FromRoute][Required] string userID)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(InlineResponseDefault3));

            string exampleJson = null;
            exampleJson = "{\n  \"address2_utcoffset\" : \"address2_utcoffset\",\n  \"userpuid\" : \"userpuid\",\n  \"address1_city\" : \"address1_city\",\n  \"address2_name\" : \"address2_name\",\n  \"address1_latitude\" : \"address1_latitude\",\n  \"address1_addresstypecode\" : \"address1_addresstypecode\",\n  \"passportlo\" : \"passportlo\",\n  \"_calendarid_value\" : \"_calendarid_value\",\n  \"yammeremailaddress\" : \"yammeremailaddress\",\n  \"emailrouteraccessapproval\" : 7,\n  \"yomimiddlename\" : \"yomimiddlename\",\n  \"personalemailaddress\" : \"personalemailaddress\",\n  \"skills\" : \"skills\",\n  \"yomifullname\" : \"yomifullname\",\n  \"entityimage_url\" : \"entityimage_url\",\n  \"address1_line1\" : \"address1_line1\",\n  \"address1_shippingmethodcode\" : \"address1_shippingmethodcode\",\n  \"disabledreason\" : \"disabledreason\",\n  \"_modifiedonbehalfby_value\" : \"_modifiedonbehalfby_value\",\n  \"address1_line3\" : \"address1_line3\",\n  \"address1_longitude\" : \"address1_longitude\",\n  \"address1_line2\" : \"address1_line2\",\n  \"internalemailaddress\" : \"internalemailaddress\",\n  \"address2_fax\" : \"address2_fax\",\n  \"address1_utcoffset\" : \"address1_utcoffset\",\n  \"address1_stateorprovince\" : \"address1_stateorprovince\",\n  \"timezoneruleversionnumber\" : \"timezoneruleversionnumber\",\n  \"yomifirstname\" : \"yomifirstname\",\n  \"incomingemaildeliverymethod\" : 6,\n  \"setupuser\" : true,\n  \"@odata.etag\" : \"@odata.etag\",\n  \"_positionid_value\" : \"_positionid_value\",\n  \"ownerid\" : \"ownerid\",\n  \"lastname\" : \"lastname\",\n  \"address2_city\" : \"address2_city\",\n  \"organizationid\" : \"organizationid\",\n  \"address2_postalcode\" : \"address2_postalcode\",\n  \"mobilealertemail\" : \"mobilealertemail\",\n  \"modifiedon\" : \"modifiedon\",\n  \"invitestatuscode\" : 2,\n  \"preferredaddresscode\" : \"preferredaddresscode\",\n  \"yammeruserid\" : \"yammeruserid\",\n  \"address1_upszone\" : \"address1_upszone\",\n  \"address2_latitude\" : \"address2_latitude\",\n  \"_businessunitid_value\" : \"_businessunitid_value\",\n  \"address2_addressid\" : \"address2_addressid\",\n  \"utcconversiontimezonecode\" : \"utcconversiontimezonecode\",\n  \"sharepointemailaddress\" : \"sharepointemailaddress\",\n  \"address1_postalcode\" : \"address1_postalcode\",\n  \"employeeid\" : \"employeeid\",\n  \"_territoryid_value\" : \"_territoryid_value\",\n  \"issyncwithdirectory\" : true,\n  \"_mobileofflineprofileid_value\" : \"_mobileofflineprofileid_value\",\n  \"nickname\" : \"nickname\",\n  \"overriddencreatedon\" : \"overriddencreatedon\",\n  \"address2_county\" : \"address2_county\",\n  \"address2_shippingmethodcode\" : \"address2_shippingmethodcode\",\n  \"defaultodbfoldername\" : \"defaultodbfoldername\",\n  \"entityimageid\" : \"entityimageid\",\n  \"jobtitle\" : \"jobtitle\",\n  \"versionnumber\" : 3,\n  \"_queueid_value\" : \"_queueid_value\",\n  \"createdon\" : \"createdon\",\n  \"address2_telephone2\" : \"address2_telephone2\",\n  \"address2_telephone1\" : \"address2_telephone1\",\n  \"_modifiedby_value\" : \"_modifiedby_value\",\n  \"address2_telephone3\" : \"address2_telephone3\",\n  \"address2_line3\" : \"address2_line3\",\n  \"address2_postofficebox\" : \"address2_postofficebox\",\n  \"processid\" : \"processid\",\n  \"address2_line1\" : \"address2_line1\",\n  \"address2_line2\" : \"address2_line2\",\n  \"address1_name\" : \"address1_name\",\n  \"stageid\" : \"stageid\",\n  \"passporthi\" : \"passporthi\",\n  \"address1_telephone2\" : \"address1_telephone2\",\n  \"address1_telephone3\" : \"address1_telephone3\",\n  \"importsequencenumber\" : \"importsequencenumber\",\n  \"windowsliveid\" : \"windowsliveid\",\n  \"isintegrationuser\" : true,\n  \"islicensed\" : true,\n  \"address1_postofficebox\" : \"address1_postofficebox\",\n  \"preferredemailcode\" : \"preferredemailcode\",\n  \"address1_country\" : \"address1_country\",\n  \"address2_stateorprovince\" : \"address2_stateorprovince\",\n  \"outgoingemaildeliverymethod\" : 2,\n  \"address1_composite\" : \"address1_composite\",\n  \"mobilephone\" : \"mobilephone\",\n  \"_cat_fullname_value\" : \"_cat_fullname_value\",\n  \"address1_telephone1\" : \"address1_telephone1\",\n  \"isdisabled\" : true,\n  \"domainname\" : \"domainname\",\n  \"@odata.context\" : \"@odata.context\",\n  \"address1_addressid\" : \"address1_addressid\",\n  \"applicationiduri\" : \"applicationiduri\",\n  \"_defaultmailbox_value\" : \"_defaultmailbox_value\",\n  \"defaultfilterspopulated\" : true,\n  \"address1_fax\" : \"address1_fax\",\n  \"entityimage\" : \"entityimage\",\n  \"salutation\" : \"salutation\",\n  \"address2_composite\" : \"address2_composite\",\n  \"caltype\" : 5,\n  \"governmentid\" : \"governmentid\",\n  \"isemailaddressapprovedbyo365admin\" : true,\n  \"firstname\" : \"firstname\",\n  \"homephone\" : \"homephone\",\n  \"exchangerate\" : \"exchangerate\",\n  \"entityimage_timestamp\" : 5,\n  \"title\" : \"title\",\n  \"address2_addresstypecode\" : \"address2_addresstypecode\",\n  \"yomilastname\" : \"yomilastname\",\n  \"identityid\" : 1,\n  \"_createdby_value\" : \"_createdby_value\",\n  \"displayinserviceviews\" : \"displayinserviceviews\",\n  \"applicationid\" : \"applicationid\",\n  \"_parentsystemuserid_value\" : \"_parentsystemuserid_value\",\n  \"address1_county\" : \"address1_county\",\n  \"address2_country\" : \"address2_country\",\n  \"userlicensetype\" : 9,\n  \"_createdonbehalfby_value\" : \"_createdonbehalfby_value\",\n  \"middlename\" : \"middlename\",\n  \"_transactioncurrencyid_value\" : \"_transactioncurrencyid_value\",\n  \"traversedpath\" : \"traversedpath\",\n  \"azureactivedirectoryobjectid\" : \"azureactivedirectoryobjectid\",\n  \"photourl\" : \"photourl\",\n  \"address2_longitude\" : \"address2_longitude\",\n  \"systemuserid\" : \"systemuserid\",\n  \"address2_upszone\" : \"address2_upszone\",\n  \"fullname\" : \"fullname\",\n  \"preferredphonecode\" : \"preferredphonecode\",\n  \"accessmode\" : 0\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponseDefault3>(exampleJson)
            : default(InlineResponseDefault3);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// GetUserRecordPermissions
        /// </summary>

        /// <param name="systemUserID"></param>
        /// <param name="target"></param>
        /// <response code="0">default</response>
        [HttpGet]
        [Route("//api/data/v9.1/systemusers({SystemUserID})/Microsoft.Dynamics.CRM.RetrievePrincipalAccess(Target =@Target)")]
        public virtual IActionResult GetUserRecordPermissions([FromRoute][Required] string systemUserID, [FromQuery] string target)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(InlineResponseDefault4));

            string exampleJson = null;
            exampleJson = "{\n  \"AccessRights\" : \"AccessRights\",\n  \"@odata.context\" : \"@odata.context\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponseDefault4>(exampleJson)
            : default(InlineResponseDefault4);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// GetUsers
        /// </summary>
        /// <remarks>GetUsers</remarks>
        /// <param name="select"></param>
        /// <param name="filter"></param>
        /// <param name="orderby"></param>
        /// <response code="0">default</response>
        [HttpGet]
        [Route("//api/data/v9.0/systemusers")]
        public virtual IActionResult GetUsers([FromQuery] string select, [FromQuery] string filter, [FromQuery] string orderby)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(InlineResponseDefault5));

            string exampleJson = null;
            exampleJson = "{\n  \"@odata.context\" : \"@odata.context\",\n  \"value\" : [ {\n    \"firstname\" : \"firstname\",\n    \"@odata.etag\" : \"@odata.etag\",\n    \"nickname\" : \"nickname\",\n    \"systemuserid\" : \"systemuserid\",\n    \"fullname\" : \"fullname\",\n    \"ownerid\" : \"ownerid\",\n    \"azureactivedirectoryobjectid\" : \"azureactivedirectoryobjectid\",\n    \"lastname\" : \"lastname\"\n  }, {\n    \"firstname\" : \"firstname\",\n    \"@odata.etag\" : \"@odata.etag\",\n    \"nickname\" : \"nickname\",\n    \"systemuserid\" : \"systemuserid\",\n    \"fullname\" : \"fullname\",\n    \"ownerid\" : \"ownerid\",\n    \"azureactivedirectoryobjectid\" : \"azureactivedirectoryobjectid\",\n    \"lastname\" : \"lastname\"\n  } ]\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponseDefault5>(exampleJson)
            : default(InlineResponseDefault5);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// PostToProjectTeamRoles
        /// </summary>
        /// <remarks>PostToProjectTeamRoles</remarks>
        /// <param name="accept"></param>
        /// <param name="prefer"></param>
        /// <param name="xMsUserAgent"></param>
        /// <param name="xMsClientSessionId"></param>
        /// <param name="xMsClientRequestId"></param>
        /// <param name="requestId"></param>
        /// <param name="clientSessionId"></param>
        /// <param name="formLoadId"></param>
        /// <param name="acceptLanguage"></param>
        /// <param name="cacheControl"></param>
        /// <param name="contentType"></param>
        /// <param name="body"></param>
        /// <response code="0">default</response>
        [HttpPost]
        [Route("//api/data/v9.0/cat_projectteamroleses")]
        public virtual IActionResult PostToProjectTeamRoles([FromHeader] string accept, [FromHeader] string prefer, [FromHeader] string xMsUserAgent, [FromHeader] string xMsClientSessionId, [FromHeader] string xMsClientRequestId, [FromHeader] string requestId, [FromHeader] string clientSessionId, [FromHeader] string formLoadId, [FromHeader] string acceptLanguage, [FromHeader] string cacheControl, [FromHeader] string contentType, [FromBody] Body3 body)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Object));

            string exampleJson = null;
            exampleJson = "\"\"";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// RemoveUserFromAccessTeamTeamplate
        /// </summary>

        /// <param name="userID"></param>
        /// <param name="body"></param>
        /// <response code="0">default</response>
        [HttpPost]
        [Route("//api/data/v9.0/systemusers({userID})/Microsoft.Dynamics.CRM.RemoveUserFromRecordTeam")]
        public virtual IActionResult RemoveUserFromAccessTeamTeamplate([FromRoute][Required] string userID, [FromBody] Body2 body)
        {
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Object));

            string exampleJson = null;
            exampleJson = "\"\"";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        //End
    }
}
