Sigma.service("PerspectiveService", function ($http) {
    //CreatePerspective
    this.CreatePerspective = function (name, weight, perspectiveStatus) {
        var response = $http({
            method: "post",
            url: "/Perspective/CreatePerspective",
            params: {
                Name: name,
                Weight: weight,
                PerspectiveStatus: perspectiveStatus
            }
        });
        return response;
    }

    //EditPerspective
    this.EditPerspective = function (_id, name, weight, perspectiveStatus) {
        var response = $http({
            method: "post",
            url: "/Perspective/EditPerspective",
            params: {
                _id: _id,
                Name: name,
                Weight: weight,
                PerspectiveStatus: perspectiveStatus
            }
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