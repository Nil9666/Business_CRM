import { WizeTech_Business_CRMTemplatePage } from './app.po';

describe('WizeTech_Business_CRM App', function() {
  let page: WizeTech_Business_CRMTemplatePage;

  beforeEach(() => {
    page = new WizeTech_Business_CRMTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
