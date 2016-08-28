Sigma.service("BalanceScoreCardService", function ($http) {
    //CreateBalanceScoreCard
    this.CreateBalanceScoreCard = function (BalanceScoreCard) {
        var response = $http({
            method: "post",
            url: "/BalanceScoreCard/CreateBalanceScoreCard",
            data: JSON.stringify(BalanceScoreCard),
            dataType: "json"
        });
        return response;
    }

    //EditBalanceScoreCard
    this.EditBalanceScoreCard = function (BalanceScoreCard) {
        var response = $http({
            method: "post",
            url: "/BalanceScoreCard/EditBalanceScoreCard",
            data: JSON.stringify(BalanceScoreCard),
            dataType: "json"
        });
        return response;
    }

    //DeleteBalanceScoreCard
    this.DeleteBalanceScoreCard = function (BalanceScoreCardId) {
        var response = $http({
            method: "post",
            url: "/BalanceScoreCard/DeleteBalanceScoreCard",
            params: {
                BalanceScoreCardId: BalanceScoreCardId
            }
        });
        return response;
    }

    //GetAllBalanceScoreCard
    this.GetAllMetrics = function () {
        return $http.get("/BalanceScoreCard/GetAllBalanceScoreCard");
    };

    //GetBalanceScoreCardById
    this.GetBalanceScoreCardById = function (BalanceScoreCardId) {
        var response = $http({
            method: "post",
            url: "/BalanceScoreCard/GetBalanceScoreCardById",
            params: {
                BalanceScoreCardId: BalanceScoreCardId
            }
        });
        return response;
    }

});