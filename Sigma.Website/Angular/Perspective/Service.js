Sigma.service("PerspectiveService", function ($http) {
    //CreatePerspective
    this.CreatePerspective = function (Perspective) {
        var response = $http({
            method: "post",
            url: "/Perspective/CreatePerspective",
            data: JSON.stringify(Perspective),
            dataType: "json"
        });
        return response;
    }

    //EditPerspective
    this.EditPerspective = function (Perspective) {
        var response = $http({
            method: "post",
            url: "/Perspective/EditPerspective",
            data: JSON.stringify(Perspective),
            dataType: "json"
        });
        return response;
    }

    //DeletePerspective
    this.DeletePerspective = function (PerspectiveId) {
        var response = $http({
            method: "post",
            url: "/BalanceScoreCard/DeletePerspective",
            params: {
                PerspectiveId: PerspectiveId
            }
        });
        return response;
    }
    
    //GetAll
    this.GetAllPerspective = function () {
        return $http.get("/Perspective/GetAllPerspective");
    };

    //GetById
    this.GetPerspectiveById = function (PerspectiveId) {
        var response = $http({
            method: "post",
            url: "/Perspective/GetPerspectiveById",
            params: {
                PerspectiveId: PerspectiveId
            }
        });
        return response;
    }

});