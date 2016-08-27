Sigma.service("PerspectiveService", function ($http) {
    //GetAll
    this.GetAllPerspective = function () {
        return $http.get("Perspective/GetAllPerspective");
    };
});