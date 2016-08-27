using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma.Website.ViewModels
{
    public class MetricViewModel
    {
        public string _id { get; set; }
        public string Alias { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Formula { get; set; }
        public int MeasurementFrequency { get; set; }
        public DateTime MeasurementEndDate { get; set; }
        public DateTime MeasurementStartDate { get; set; }
        public string Goal { get; set; }
        public string Name { get; set; }
        public Objective AssociatedObjective { get; set; }
        public string ResponsibleConfiguration { get; set; }
        public string ResponsibleRegistration { get; set; }
        public string Trend { get; set; }
        public int UnitOfMeasurement { get; set; }
        public DateTime RegisterTime { get; set; }
    }
}