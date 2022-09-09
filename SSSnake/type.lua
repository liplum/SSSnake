require("utils")
AllContents = {}

function Content(name)
    local c = {
        name = name,
        load = function() end,
        init = function() end,
    }
    table.insert(AllContents, c)
    return c
end

function SnakeType(name)
    local t = Content(name)
    t.load = function()
        t.headImg = LoadImage(t.name .. "-head")
        t.bodyImg = LoadImage(t.name .. "-body")
        t.tailImg = LoadImage(t.name .. "-tail")
    end
end
