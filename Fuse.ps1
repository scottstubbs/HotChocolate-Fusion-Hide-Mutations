param(
    [string]$Project
)

if ($Project -eq $null -or $Project -eq '') {
    # No project specified, run commands for all projects
    $projects = @('./Cars', './Owners')
} else {
    # Run commands for the specified project
    $projects = @($Project)
}

foreach ($proj in $projects) {
    Write-Host "Processing project: $proj"

    # Export the schema for the project
    dotnet run --project $proj -- schema export --output schema.graphql

    # Pack the subgraph
    fusion subgraph pack -w $proj

    # Compose the subgraph into the Gateway configuration
    fusion compose -p .\Gateway\gateway.fgp -s $proj
}
