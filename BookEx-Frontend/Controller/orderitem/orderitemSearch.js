var app = angular.module('my-app', []);
app.controller('orderitemSearchCtrl', function($scope, $http) {
    $scope.searchOrderItem = function() {
        $http.get("https://localhost:44373/api/orderitem/" + $scope.orderitemId)
            .then(function(response) {
                $scope.searchResult = response.data;
            })
            .catch(function(error) {
                console.log(error);
            });
    };
});