Sigma.service("MetricService", function ($http) {
    //CreateMetric
    this.CreateUser = function (alias,
                                code,
                                description,
                                formula,
                                measurementFrequency,
                                measurementEndDate,
                                measurementStartDate,
                                goal,
                                name,
                                associatedObjectiveId,
                                responsibleConfiguration,
                                responsibleRegistration,
                                trend,
                                unitOfMeasurement) {
        var response = $http({
            method: "post",
            url: "/Metric/CreateMetric",
            params: {
                Alias: alias,
                Code: code,
                Description: description,
                Formula: formula,
                MeasurementFrequency: measurementFrequency,
                MeasurementEndDate: measurementEndDate,
                MeasurementStartDate: measurementStartDate,
                Goal: goal,
                Name: name,
                AssociatedObjectiveId: associatedObjectiveId,
                ResponsibleConfiguration: responsibleConfiguration,
                ResponsibleRegistration: responsibleRegistration,
                Trend: trend,
                UnitOfMeasurement: unitOfMeasurement,
            }
        });
        return response;
    }

    //EditMetric
    this.EditMetric = function (_id,
                                alias,
                                code,
                                description,
                                formula,
                                measurementFrequency,
                                measurementEndDate,
                                measurementStartDate,
                                goal,
                                name,
                                associatedObjectiveId,
                                responsibleConfiguration,
                                responsibleRegistration,
                                trend,
                                unitOfMeasurement) {
        var response = $http({
            method: "post",
            url: "/Metric/EditMetric",
            params: {
                _id: _id,
                Alias: alias,
                Code: code,
                Description: description,
                Formula: formula,
                MeasurementFrequency: measurementFrequency,
                MeasurementEndDate: measurementEndDate,
                MeasurementStartDate: measurementStartDate,
                Goal: goal,
                Name: name,
                AssociatedObjectiveId: associatedObjectiveId,
                ResponsibleConfiguration: responsibleConfiguration,
                ResponsibleRegistration: responsibleRegistration,
                Trend: trend,
                UnitOfMeasurement: unitOfMeasurement,
            }
        });
        return response;
    }

    //DeleteMetric
    this.DeleteMetric = function (MetricId) {
        var response = $http({
            method: "post",
            url: "/Metric/DeleteMetric",
            params: {
                MetricId: MetricId
            }
        });
        return response;
    }

    //GetAll
    this.GetAllMetrics = function () {
        return $http.get("/Metric/GetAllMetrics");
    };

    //GetById
    this.GetMetricById = function (MetricId) {
        var response = $http({
            method: "post",
            url: "/Metric/GetMetricById",
            params: {
                MetricId: MetricId
            }
        });
        return response;
    }

});