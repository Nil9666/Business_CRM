import { browser, element, by } from 'protractor';

export class WizeTech_Business_CRMTemplatePage {
  navigateTo() {
    return browser.get('/');
  }

  getParagraphText() {
    return element(by.css('app-root h1')).getText();
  }
}
