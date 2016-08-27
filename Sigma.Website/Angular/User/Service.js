Sigma.service("UserService", function ($http) {
    //GetAll
    this.GetEquipos = function () {
        return $http.get("User/GetEquipos");
    };
});