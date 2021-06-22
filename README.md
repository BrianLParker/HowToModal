

# How To Modal



I see a lot of posts on stack exchange with people in a mess with modals.

They are a fundamentally just html and css. There is no need to call JavaScript or install some bloated library just for a modal.

Essentially they are just a div that covers your existing page and shows content in the centre (usually).
In this project I capture the render fragment for the modal and via service send it to the layout for display to achieve the html hierarchy I need to blur the background.

In html the blur filter effect is applied to an element and blurs all of its contents. This is why it is necessary to push the render fragment to layout, to get it outside the blur. 

Even though I'm using this technique you can still interact with the modal contents as you would any other component on the page it came from no special handling.

I takes a little work to set it up, in the end you will have a reusable modal component that not only looks good but is easy to use.

**Provide the service for injection:**
```
builder.Services.AddScoped<IModalService, ModalService>();
```
**Wrap your layout with the Modal Launcher component**
```
@inherits LayoutComponentBase
<ModalLauncher>
   ...
</ModalLauncher>
```

**Basic Modal Usage:**
```
<button @onclick="()=>modal.ShowModal()" 
        class="btn btn-primary" >Show Modal</button>

<Modal @ref="@modal" OnClose="Modal1Closed">
    <MyModalContent />
</Modal>

@code {
    private Modal modal;
    private void Modal1Closed(ModalCloseState modalCloseState) 
        => Console.WriteLine($"ModalCloseState : {modalCloseState}");
}
```

**Template Modal Usage:**
```
<ul class="list-group">
    @foreach (var someModel in someData)
    {
        <li @key=someModel.Id class="d-flex flex-row list-group-item">
            <div class="col-2">  @someModel.Name</div>
            <button @onclick="()=>OpenModal(someModel)" class="btn btn-primary btn-sm">edit</button>
        </li>
    }
</ul>

<TemplateModal @ref="@modal" TContent="SomeDataModel" OnClose="ModalClosed" Background="#0000ff77" BlurPixels="3">
    <SomeModelEditForm SomeData="@context" />
</TemplateModal>

@code {
    private TemplateModal<SomeDataModel> modal;
    private SomeDataModel currentModel;
    private IEnumerable<SomeDataModel> someData;

    protected override void OnInitialized() 
        => someData = LoadData();  

    private void OpenModal(SomeDataModel data)
    {
        currentModel = data;
        var temp = new SomeDataModel();
        CopyModel(data, temp);
        modal.ShowModal(temp);
    }
    
    private void ModalClosed(ModalResult<SomeDataModel> modalResult)
    {
        if(modalResult.CloseState == ModalCloseState.Ok)
        {
            CopyModel(modalResult.Value, currentModel);
            StateHasChanged();
        }            
    }

    private void CopyModel(SomeDataModel source, SomeDataModel dest)
    {
        // use a clone method or copy the properties.
    }
}
```

**Modal Parameters**

| Paramater  | Type  | Default  |  |
|--|--|--|--|
| Background | string | #00000077 | The colour of the background. For example "#000000ff77" for tanslucent blue|
| BlurPixels | int | 5 | The quantity of blur pixels
| AllowBackgroundClick | bool | true | When true clicking on the background closes the modal.
```
<Modal @ref="@modal" 
             Background="#0088ff77" 
             BlurPixels="3" 
             AllowBackgroundClick="false">
 ```