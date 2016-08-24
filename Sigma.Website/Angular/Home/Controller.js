Sigma.controller("HomeController", function ($scope, $window, HomeService) {

    $scope.showAddUpdate = false;
    $scope.LoginButtonText = "Login";

    $scope.submitToLogin = function () {
        $scope.MVCAction = "Login";
        $scope.MVCController = "Dashboard";

        var loginProcess = HomeService.Login($scope.Company, $scope.Username, $scope.Password);

        loginProcess.then(function (response) {
            console.log(response.data.Authentication);
            $scope.LoginButtonText = "Login";
            if (response.data.Authentication.Success == true) {
                if (typeof (Storage) !== "undefined") {
                    localStorage.setItem('AccessToken', response.data.Authentication.Token);

                    $window.location.href = '/Dashboard/Index';
                } else {
                    // Sorry! No Web Storage support..
                }
            }
        })
    }
});