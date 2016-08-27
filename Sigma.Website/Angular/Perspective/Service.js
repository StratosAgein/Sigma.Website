Sigma.service("PerspectiveService", function ($http) {
    //GetAll
    this.GetAllPerspective = function () {
        return $http.get("Perspective/GetAllPerspective");
    };
    //GetById
    this.GetPerspective = function (PerspectiveId) {
        var response = $http({
            method: "post",
            url: "Perspective/GetPerspectiveById",
            params: {
                PerspectiveId: JSON.stringify(PerspectiveId)
            }
        });
        return response;
    }
});