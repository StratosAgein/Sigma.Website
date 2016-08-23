Sigma.controller("HomeController", function ($scope, HomeService) {

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
                    sessionStorage.setItem('Token', response.data.Authentication.Token);


                } else {
                    // Sorry! No Web Storage support..
                }
            }
        })
    }
});