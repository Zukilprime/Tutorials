function maskify(cc) {
  if (cc.length > 4) {
    let mask = cc.substring(0, cc.length - 4);
    let newMask = [];
    let addReplacer = [];
    for (const c of mask) {
      newMask.push(c);
    }
    newMask.forEach(e => {
      addReplacer.push("#");
    });
    console.log(addReplacer);
    let removeSpace = addReplacer.join("");
    console.log(removeSpace + cc.substring(cc.length - 4, cc.length));
  }
  console.log(cc);
}
maskify("abc");
