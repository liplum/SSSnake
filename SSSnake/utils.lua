AssetsFolder = "assets"

function LoadImage(name)
    return love.graphics.newImage(AssetsFolder .. "/" .. name .. ".png")
end

function PrintAPI(t, supername)
    local seen = {}
    local function func(o, parent)

        if seen[o] == true then
            return
        else
            seen[o] = true
        end
        for name, field in pairs(o) do
            local full_name = parent .. "." .. name
            print(full_name)
            if type(field) == "table" then
                func(field, full_name)
            end
        end
    end

    func(t, supername)
end
