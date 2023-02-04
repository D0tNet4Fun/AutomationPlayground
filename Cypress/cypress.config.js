module.exports = {
  e2e: {
    setupNodeEvents(on, config) {
      // implement node event listeners here
      // from https://docs.cypress.io/api/plugins/browser-launch-api
      on('before:browser:launch', (browser, launchOptions) => {
        if (browser.name === "chrome") {
          // launchOptions.args.push('--auto-open-devtools-for-tabs')
          console.log(launchOptions.args);
        }      
        return launchOptions
      })
    },
  },
};
