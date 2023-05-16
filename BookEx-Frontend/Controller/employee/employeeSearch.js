var app = angular.module('my-app', []);

app.controller('employeeSearchCtrl', function($scope, $http) {
    $scope.searchId = "";
    $scope.employee = null;

    $scope.searchEmployee = function() {
        var url = "https://localhost:44373/api/employee/" + $scope.searchId;
        $http.get(url)
            .then(function(resp) {
                $scope.employee = resp.data;
            })
            .catch(function(err) {
                console.log(err);
                $scope.employee = null;
            });
    };
});
