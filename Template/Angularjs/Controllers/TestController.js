app.controller('TestController', ['$scope', 'myConfig', function ($scope, myConfig) {
  $scope.testmessage = "Setup angularjs application in visual studio 2019 successfully ";
  $scope.appName = myConfig.applicationName;

  $scope.model = {title: 'Our Menu'};
  $scope.currentDate = new Date();

  $scope.renameTitle = function (newValue) {
    $scope.title = newValue;
  }

  $scope.changeMainDish = function (item) {
    $scope.model.mainDish = item;
  }

  $scope.$watch('model.mainDish', function (newValue, oldValue) {
    if (newValue === 'BBQ Chicken Pizza') {
      alert('You have selected the BBQ Chicken Pizza!');
    }
  });
}]);