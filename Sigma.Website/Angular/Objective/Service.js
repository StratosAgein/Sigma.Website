Sigma.service("ObjectiveService", function ($http) {
    //GetAll
    this.GetAllObjectives = function () {
        return $http.get("Objective/GetAllObjectives");
    };
});