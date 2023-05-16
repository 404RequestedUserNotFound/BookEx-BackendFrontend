var app = angular.module('my-app', []);

app.controller('orderSearchCtrl', function($scope, $http) {
    $scope.searchId = "";
    $scope.order = null;

    $scope.searchOrder = function() {
        var url = "https://localhost:44373/api/order/" + $scope.searchId;
        $http.get(url)
            .then(function(resp) {
                $scope.order = resp.data;
            })
            .catch(function(err) {
                console.log(err);
                $scope.order = null;
            });
    };
});
