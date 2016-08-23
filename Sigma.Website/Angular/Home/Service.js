Sigma.service("HomeService", function ($http) {
    this.Login = function (company, username, password) {
        LoginButtonText = "Validating...";

        var response = $http({
            method: "post",
            url: "/Dashboard/Login",
            params: {
                Company: company,
                Email: username,
                Password: password
            }
        });
        return response;
    }
});