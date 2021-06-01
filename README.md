
# How To Modal



I see a lot of posts on stack exchange with people in a mess with modals.

They are a fundamentally just html and css. There is no need to call JavaScript or install some bloated library just for a modal.

Essentially they are just a div that covers your existing page and shows content in the centre (usually).
In this project I capture the render fragment for the modal and via service send it to the layout for display to achieve the html hierarchy I need to blur the background.

In html the blur filter effect is applied to an element and blurs all of its contents. This is why it is necessary to push the render fragment to layout, to get it outside the blur. 

Even thought I'm using this technique you can still interact with the modal contents as you would any other component on the page it came from no special handling.

I takes a little work to set it up, in the end you will have a reusable modal component that not only looks good but is easy to use.