Sigma.service("ObjectiveService", function ($http) {
    //CreateObjective
    this.CreateObjective = function (name, alias, description) {
        var response = $http({
            method: "post",
            url: "/Objective/CreateObjective",
            params: {
                Name: name,
                Alias: alias,
                Description: description
            }
        });
        return response;
    }

    //EditObjective
    this.EditObjective = function (_id, name, alias, description) {
        var response = $http({
            method: "post",
            url: "/Objective/EditObjective",
            params: {
                _id: _id,
                Name: name,
                Alias: alias,
                Description: description
            }
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