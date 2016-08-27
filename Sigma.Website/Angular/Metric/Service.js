Sigma.service("MetricService", function ($http) {
    //GetAll
    this.GetAllMetrics = function () {
        return $http.get("Metric/GetAllMetrics");
    };
    //GetById
    this.GetMetric = function (MetricId) {
        var response = $http({
            method: "post",
            url: "Metric/GetMetricById",
            params: {
                MetricId: JSON.stringify(MetricId)
            }
        });
        return response;
    }
});