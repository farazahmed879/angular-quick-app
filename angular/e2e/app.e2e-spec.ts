import { GSSTemplatePage } from './app.po';

describe('GSS App', function() {
  let page: GSSTemplatePage;

  beforeEach(() => {
    page = new GSSTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
