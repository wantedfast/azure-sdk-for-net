// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines how the Suggest API should apply to a group of fields in the index. </summary>
    public partial class SearchSuggester
    {

        /// <summary> Initializes a new instance of SearchSuggester. </summary>
        /// <param name="name"> The name of the suggester. </param>
        /// <param name="searchMode"> A value indicating the capabilities of the suggester. </param>
        /// <param name="sourceFields"> The list of field names to which the suggester applies. Each field must be searchable. </param>
        internal SearchSuggester(string name, string searchMode, IList<string> sourceFields)
        {
            Name = name;
            SearchMode = searchMode;
            SourceFields = sourceFields;
        }

        /// <summary> The name of the suggester. </summary>
        public string Name { get; set; }
        /// <summary> The list of field names to which the suggester applies. Each field must be searchable. </summary>
        public IList<string> SourceFields { get; set; }
    }
}
