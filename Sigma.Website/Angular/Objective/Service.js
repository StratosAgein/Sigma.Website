Sigma.service("ObjectiveService", function ($http) {
    //CreateObjective
    this.CreateObjective = function (User) {
        var response = $http({
            method: "post",
            url: "/Objective/CreateObjective",
            data: JSON.stringify(Objective),
            dataType: "json"
        });
        return response;
    }

    //EditObjective
    this.EditObjective = function (Objective) {
        var response = $http({
            method: "post",
            url: "/Objective/EditObjective",
            data: JSON.stringify(Objective),
            dataType: "json"
        });
        return response;
    }

    //DeleteObjective
    this.DeleteClient = function (ObjectiveId) {
        var response = $http({
            method: "post",
            url: "/Objective/DeleteObjective",
            params: {
                ObjectiveId: ObjectiveId
            }
        });
        return response;
    }

    //GetAllObjectives
    this.GetAllObjectives = function () {
        return $http.get("/Objective/GetAllObjectives");
    };

    //GetObjectiveById
    this.GetObjectiveById = function (ObjectiveId) {
        var response = $http({
            method: "post",
            url: "/Objective/GetObjectiveById",
            params: {
                ObjectiveId: ObjectiveId
            }
        });
        return response;
    }

});