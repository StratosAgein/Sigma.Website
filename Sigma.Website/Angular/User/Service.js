/// <reference path="Service.js" />
Sigma.service("UserService", function ($http) {
    //CreateUser
    this.CreateUser = function (name, lastname, email, password, status, phone, roles) {
        var response = $http({
            method: "post",
            url: "/User/CreateUser",
            params: {
                Name: name,
                Lastname: lastname,
                Email: email,
                Password: password,
                Status: status,
                Phone: phone,
                Roles: roles
            }
        });
        return response;
    }

    //EditUser
    this.EditUser = function (_id, name, lastname, email, password, status, phone, roles) {
        var response = $http({
            method: "post",
            url: "/User/EditUser",
            params: {
                _id: _id,
                Name: name,
                Lastname: lastname,
                Email: email,
                Password: password,
                Status: status,
                Phone: phone,
                Roles: roles
            }
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