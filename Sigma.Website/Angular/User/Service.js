/// <reference path="Service.js" />
Sigma.service("UserService", function ($http) {
    //CreateUser
    this.CreateUser = function (User) {
        var response = $http({
            method: "post",
            url: "/User/CreateUser",
            data: JSON.stringify(User),
            dataType: "json"
        });
        return response;
    }

    //EditUser
    this.EditUser = function (User) {
        var response = $http({
            method: "post",
            url: "/User/EditUser",
            data: JSON.stringify(User),
            dataType: "json"
        });
        return response;
    }

    //DeleteUser
    this.DeleteUser = function (UserId) {
        var response = $http({
            method: "post",
            url: "/User/DeleteUser",
            params: {
                UserId: UserId
            }
        });
        return response;
    }

    //GetAllUsers
    this.GetAllUsers = function () {
        return $http.get("/User/GetAllUsers");
    };

    //GetById
    this.GetUserById = function (UserId) {
        var response = $http({
            method: "post",
            url: "/Perspective/GetUserById",
            params: {
                UserId: UserId
            }
        });
        return response;
    }

});