﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yny_005.Model
{
    public class Reward
    {
        public string RewardType { get; set; }
        public string RewardName { get; set; }
        public bool RewardState { get; set; }
        public bool NeedProcess { get; set; }
        public int RewardIndex { get; set; }
    }
}
