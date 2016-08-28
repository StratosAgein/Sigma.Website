Sigma.service("MetricService", function ($http) {
    //CreateMetric
    this.CreateUser = function (Metric) {
        var response = $http({
            method: "post",
            url: "/Metric/CreateMetric",
            data: JSON.stringify(Metric),
            dataType: "json"
        });
        return response;
    }

    //EditMetric
    this.EditMetric = function (Metric) {
        var response = $http({
            method: "post",
            url: "/Metric/EditMetric",
            data: JSON.stringify(Metric),
            dataType: "json"
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