var app = angular.module('my-app', []);
app.controller('adminSearchCtrl', function($scope, $http) {
    $scope.searchAdmin = function() {
        $http.get("https://localhost:44373/api/admin/" + $scope.adminId)
            .then(function(response) {
                $scope.searchResult = response.data;
            })
            .catch(function(error) {
                console.log(error);
            });
    };
});
