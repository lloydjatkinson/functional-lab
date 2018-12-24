const presets = [
    [
      "@babel/env",
      {
        targets: {
          edge: "15",
          firefox: "60",
          chrome: "60",
          safari: "11",
          ie: "11"
        },
        useBuiltIns: "usage",
      },
    ],
  ];
  
  module.exports = { presets };