Sigma.service("BalanceScoreCardService", function ($http) {
    //GetAll
    this.GetAllMetrics = function () {
        return $http.get("BalanceScoreCard/GetAllBalanceScoreCard");
    };
    //GetById
    this.GetBalanceScoreCard = function (BalanceScoreCardId) {
        var response = $http({
            method: "post",
            url: "BalanceScoreCard/GetBalanceScoreCardById",
            params: {
                BalanceScoreCardId: JSON.stringify(BalanceScoreCardId)
            }
        });
        return response;
    }
});