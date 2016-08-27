Sigma.service("MetricService", function ($http) {
    //GetAll
    this.GetAllMetrics = function () {
        return $http.get("Metric/GetAllMetrics");
    };
});