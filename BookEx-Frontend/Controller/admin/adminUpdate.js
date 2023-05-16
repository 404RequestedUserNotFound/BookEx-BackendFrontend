var app = angular.module('my-app', []);
app.controller('adminUpdateCtrl', function($scope, $http) 
{
  $scope.updateAdmin = function() 
  {
    var data = {
        AdminId: $scope.adminId,
        FirstName: $scope.firstName,
        LastName: $scope.lastName,
        Username: $scope.username,
        Phone: $scope.phone,
        PresentAddress: $scope.presentAddress,
        PermanentAddress: $scope.permanentAddress,
        NID: $scope.nid,
        Email: $scope.email,
        Password: $scope.password,
        ConfirmPassword: $scope.confirmPassword
      };
    $http.post("https://localhost:44373/api/admin/update", data).then(function(resp) 
    {
      location.reload();

      alert("Admin profile has updated");


    }, function(err) 

    {
      alert("Please fill all the fields");


    });
  };
});
