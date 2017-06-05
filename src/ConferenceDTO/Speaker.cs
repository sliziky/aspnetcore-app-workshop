﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferenceDTO
{
    public class Speaker
    {
        public int SpeakerID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(4000)]
        public string Bio { get; set; }

        [DataType(DataType.Url)]
        [StringLength(1000)]
        public string WebSite { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
