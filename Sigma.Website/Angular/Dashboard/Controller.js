Sigma.controller("DashboardController", function ($scope, $window, DashboardService) {

    $scope.showAddUpdate = false;
    $scope.LoginButtonText = "Login";

    $scope.DashboardNavigate = function () {
        $scope.MVCAction = "Login";
        $scope.MVCController = "Dashboard";

        $window.location.href = '/Dashboard/Wizard';
    }
});