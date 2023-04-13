var fat = {
    'SP': 67836.43,
    'RJ': 36678.66,
    'MG': 29229.88,
    'ES': 27165.48,
    'Outros': 19849.53
};

var total = fat['SP'] + fat['RJ'] + fat['MG'] + fat['ES'] + fat['Outros']

for (const [estado, valor] of Object.entries(fat)) {
    var pct = (valor/total)*100
   console.log(`O faturamento de ${estado} = ${pct.toFixed(2)}`)
}
