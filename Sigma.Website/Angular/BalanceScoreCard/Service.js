Sigma.service("BalanceScoreCardService", function ($http) {
    //GetAll
    this.GetAllMetrics = function () {
        return $http.get("BalanceScoreCard/GetAllBalanceScoreCard");
    };
});