function LoadContents(contents)
    for i,content in ipairs(contents) do
        content.load()
    end
end

function InitContents(contents)
    for i,content in ipairs(contents) do
        content.init()
    end
end