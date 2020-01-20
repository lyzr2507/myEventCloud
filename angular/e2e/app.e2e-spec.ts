import { myEventCloudTemplatePage } from './app.po';

describe('myEventCloud App', function() {
  let page: myEventCloudTemplatePage;

  beforeEach(() => {
    page = new myEventCloudTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
