﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp.Models
{
    public class Calculator
    {
        public Calculator()
        {
            this.Result = 0;
        }

        public decimal LeftOperand { get; set; }

        public decimal RightOperand { get; set; }

        public string Operator { get; set; }

        public decimal Result { get; set; } 

        internal void CalculateResult()
        {
            
            if (Operator == "+")
            {
                Result = LeftOperand + RightOperand;
            }
            else if (Operator == "-")
            {
                Result = LeftOperand - RightOperand;
            }
            else if (Operator == "*")
            {
                Result = LeftOperand * RightOperand;
            }
            else
            {
                if (RightOperand != 0)
                {
                    Result = LeftOperand / RightOperand;
                }
                else
                {
                    Result = 0;
                }
            }
        }
    }
}
