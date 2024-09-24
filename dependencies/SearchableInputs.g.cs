// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Validators;
using Elements.Serialization.JSON;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Hypar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Searchable
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public  class SearchableInputs : ArgsBase
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public SearchableInputs(int @levelCount, string @levelNames, string @searchableLevelNames, SearchableInputsChoices? @choices, SearchableInputsSearchableChoices? @searchableChoices, HyparPickElement @hyparPickElement, SearchableHyparPickElement @searchableHyparPickElement, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SearchableInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @levelCount, @levelNames, @searchableLevelNames, @choices, @searchableChoices, @hyparPickElement, @searchableHyparPickElement});
            }
        
            this.LevelCount = @levelCount;
            this.LevelNames = @levelNames;
            this.SearchableLevelNames = @searchableLevelNames;
            this.Choices = @choices;
            this.SearchableChoices = @searchableChoices;
            this.HyparPickElement = @hyparPickElement;
            this.SearchableHyparPickElement = @searchableHyparPickElement;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Level count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(5, 1000)]
        public int LevelCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Level Names", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LevelNames { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Searchable Level Names", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SearchableLevelNames { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Choices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SearchableInputsChoices? Choices { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Searchable Choices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SearchableInputsSearchableChoices? SearchableChoices { get; set; }
    
        [Newtonsoft.Json.JsonProperty("HyparPick Element", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HyparPickElement HyparPickElement { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Searchable HyparPickElement", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SearchableHyparPickElement SearchableHyparPickElement { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum SearchableInputsChoices
    {
        [System.Runtime.Serialization.EnumMember(Value = @"First option")]
        First_option = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Second option")]
        Second_option = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Third option")]
        Third_option = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum SearchableInputsSearchableChoices
    {
        [System.Runtime.Serialization.EnumMember(Value = @"First option")]
        First_option = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Second option")]
        Second_option = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Third option")]
        Third_option = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class HyparPickElement 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public HyparPickElement(string @name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<HyparPickElement>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @name});
            }
        
            this.Name = @name;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SearchableHyparPickElement 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SearchableHyparPickElement(string @name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SearchableHyparPickElement>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @name});
            }
        
            this.Name = @name;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}