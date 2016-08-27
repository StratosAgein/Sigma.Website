Sigma.service("ObjectiveService", function ($http) {
    //GetAll
    this.GetAllObjectives = function () {
        return $http.get("Objective/GetAllObjectives");
    };
    //GetById
    this.GetObjective = function (ObjectiveId) {
        var response = $http({
            method: "post",
            url: "Objective/GetObjectiveById",
            params: {
                ObjectiveId: JSON.stringify(ObjectiveId)
            }
        });
        return response;
    }
});