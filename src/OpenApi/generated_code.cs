//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.11.1.0 (NJsonSchema v10.4.3.0 (Newtonsoft.Json v12.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"

namespace OpenApi.Example
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.11.1.0 (NJsonSchema v10.4.3.0 (Newtonsoft.Json v12.0.0.0))")]
    public interface IQueriesController
    {
        /// <summary>Get examples</summary>
        /// <returns>An array of examples</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ArrayOfExamples>> GetExamplesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <summary>Get example</summary>
        /// <param name="exampleId">Example id that is used as filter.</param>
        /// <returns>Example</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Example>> GetExampleByIdAsync(int exampleId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.11.1.0 (NJsonSchema v10.4.3.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class QueriesController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private IQueriesController _implementation;
    
        public QueriesController(IQueriesController implementation)
        {
            _implementation = implementation;
        }
    
        /// <summary>Get examples</summary>
        /// <returns>An array of examples</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/examples", Name = "getExamples")]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ArrayOfExamples>> GetExamples(System.Threading.CancellationToken cancellationToken)
        {
            return _implementation.GetExamplesAsync(cancellationToken);
        }
    
        /// <summary>Get example</summary>
        /// <param name="exampleId">Example id that is used as filter.</param>
        /// <returns>Example</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/examples/{exampleId}", Name = "getExampleById")]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Example>> GetExampleById([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] int exampleId, System.Threading.CancellationToken cancellationToken)
        {
            return _implementation.GetExampleByIdAsync(exampleId, cancellationToken);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.11.1.0 (NJsonSchema v10.4.3.0 (Newtonsoft.Json v12.0.0.0))")]
    public interface ICommandsController
    {
        /// <summary>Create new example</summary>
        /// <returns>Example</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Example>> CreateExampleAsync(ExampleCreate body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.11.1.0 (NJsonSchema v10.4.3.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private ICommandsController _implementation;
    
        public CommandsController(ICommandsController implementation)
        {
            _implementation = implementation;
        }
    
        /// <summary>Create new example</summary>
        /// <returns>Example</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("api/examples", Name = "createExample")]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Example>> CreateExample([Microsoft.AspNetCore.Mvc.FromBody] ExampleCreate body, System.Threading.CancellationToken cancellationToken)
        {
            return _implementation.CreateExampleAsync(body, cancellationToken);
        }
    
    }

    /// <summary>Entity that represents the `Example` structure.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Example 
    {
        /// <summary>Internal id</summary>
        [System.Text.Json.Serialization.JsonPropertyName("exampleId")]
        public int ExampleId { get; set; }
    
        /// <summary>Important field that has to be unique</summary>
        [System.Text.Json.Serialization.JsonPropertyName("something")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Something { get; set; }
    
        /// <summary>Not so important field</summary>
        [System.Text.Json.Serialization.JsonPropertyName("else")]
        public string Else { get; set; }
    
    
    }
    
    /// <summary>Model for creating a new `Example` entity.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ExampleCreate 
    {
        /// <summary>Important field that has to be unique</summary>
        [System.Text.Json.Serialization.JsonPropertyName("something")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Something { get; set; }
    
        /// <summary>Not so important field</summary>
        [System.Text.Json.Serialization.JsonPropertyName("else")]
        public string Else { get; set; }
    
    
    }
    
    /// <summary>Array structure that returns the `Example` entity search results</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ArrayOfExamples 
    {
        /// <summary>Examples</summary>
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public System.Collections.Generic.List<Example> Items { get; set; }
    
    
    }
    
    /// <summary>Generic error structure as defined by [Internet Standards](https://tools.ietf.org/html/rfc7807)</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ProblemDetails 
    {
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; }
    
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; }
    
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }
    
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string Detail { get; set; }
    
        [System.Text.Json.Serialization.JsonPropertyName("instance")]
        public string Instance { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108