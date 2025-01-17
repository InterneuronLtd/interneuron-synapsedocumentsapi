 //Interneuron synapse

//Copyright(C) 2024 Interneuron Limited

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

//See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.If not, see<http://www.gnu.org/licenses/>.
﻿//Interneuron Synapse

//Copyright(C) 2023  Interneuron Holdings Ltd

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

//See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.If not, see<http://www.gnu.org/licenses/>.

using Newtonsoft.Json;
using PuppeteerSharp.Media;

namespace SynapseDocumentsAPI.Model
{
    public class DocumentData
    {
        [JsonProperty("pdfFileName")]
        public string PdfFileName { get; set; }

        [JsonProperty("pdfHeaderHTML")]
        public string PdfHeaderHTML { get; set; }

        [JsonProperty("pdfBodyHTML")]
        public string PdfBodyHTML { get; set; }

        [JsonProperty("pdfCssUrl")]
        public string PdfCssUrl { get; set; }

        [JsonProperty("pdfFooterHTML")]
        public string PdfFooterHTML { get; set; }

        [JsonProperty("documentMargin")]
        public MarginOptions DocumentMargin { get; set; }
    }
}
