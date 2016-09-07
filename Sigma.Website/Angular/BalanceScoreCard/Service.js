Sigma.service("BalanceScoreCardService", function ($http) {
    //CreateBalanceScoreCard
    this.CreateBalanceScoreCard = function (name, organizationalUnitId) {
        var response = $http({
            method: "post",
            url: "/BalanceScoreCard/CreateBalanceScoreCard",
            params: {
                Name: name,
                OrganizationalUnitId: organizationalUnitId
            }
        });
        return response;
    }

    //EditBalanceScoreCard
    this.EditBalanceScoreCard = function (_id, name, organizationalUnitId) {
        var response = $http({
            method: "post",
            url: "/BalanceScoreCard/EditBalanceScoreCard",
            params: {
                _id: _id,
                Name: name,
                OrganizationalUnitId: organizationalUnitId
            }
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