﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Hole5
{
    public class TakeHomeCalculator
    {
        private readonly TaxRate taxRate;

        public TakeHomeCalculator(int percent)
        {
            taxRate = new TaxRate(percent);
        }

        public Money NetAmount(Money first, params Money[] rest)
        {
            List<Money> monies = rest.ToList();

            Money total = first;

            foreach (Money next in monies)
            {
                total = total.Plus(next);
            }

            Double amount = total.value * (taxRate.percent / 100d);
            Money tax = Money.Create(Convert.ToInt32(amount), total.currency);

            return total.Minus(tax);
        }
    }
}
