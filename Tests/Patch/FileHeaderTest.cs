using Xunit;
        [StrictFactAttribute]
			Assert.Equal(-1, fh.parseGitFileName(0, fh.Buffer.Length));
		    Assert.NotNull(fh.Hunks);
		    Assert.True(fh.Hunks.Count == 0);
		    Assert.False(fh.hasMetaDataChanges());
        [StrictFactAttribute]
			Assert.Equal(-1, fh.parseGitFileName(0, fh.Buffer.Length));
        [StrictFactAttribute]
			Assert.Equal(-1, fh.parseGitFileName(0, fh.Buffer.Length));
        [StrictFactAttribute]
			Assert.Equal(1, fh.parseGitFileName(0, fh.Buffer.Length));
        [StrictFactAttribute]
			Assert.Equal(GitLine(name).Length, fh.parseGitFileName(0, fh.Buffer.Length));
		    Assert.Equal(name, fh.OldName);
		    Assert.Same(fh.OldName, fh.NewName);
		    Assert.False(fh.hasMetaDataChanges());
        [StrictFactAttribute]
			Assert.True(fh.parseGitFileName(0, fh.Buffer.Length) > 0);
		    Assert.Null(fh.OldName);
		    Assert.Null(fh.NewName);
		    Assert.False(fh.hasMetaDataChanges());
        [StrictFactAttribute]
		    Assert.Equal(GitLine(name).Length, fh.parseGitFileName(0,
		    Assert.Equal(name, fh.OldName);
		    Assert.Same(fh.OldName, fh.NewName);
		    Assert.False(fh.hasMetaDataChanges());
        [StrictFactAttribute]
		    Assert.Equal(DqGitLine(dqName).Length, fh.parseGitFileName(0,
		    Assert.Equal(name, fh.OldName);
		    Assert.Same(fh.OldName, fh.NewName);
		    Assert.False(fh.hasMetaDataChanges());
        [StrictFactAttribute]
		    Assert.Equal(DqGitLine(dqName).Length, fh.parseGitFileName(0,
		    Assert.Equal(name, fh.OldName);
		    Assert.Same(fh.OldName, fh.NewName);
		    Assert.False(fh.hasMetaDataChanges());
        [StrictFactAttribute]
		    Assert.Equal(GitLine(name).Length, fh.parseGitFileName(0,
		    Assert.Equal(name, fh.OldName);
		    Assert.Same(fh.OldName, fh.NewName);
		    Assert.False(fh.hasMetaDataChanges());
        [StrictFactAttribute]
			Assert.Equal(header.Length, fh.parseGitFileName(0, fh.Buffer.Length));
		    Assert.Equal(name, fh.OldName);
		    Assert.Same(fh.OldName, fh.NewName);
		    Assert.False(fh.hasMetaDataChanges());
        [StrictFactAttribute]
		    Assert.Equal("/dev/null", fh.OldName);
		    Assert.Same(FileHeader.DEV_NULL, fh.OldName);
		    Assert.Equal("\u00c5ngstr\u00f6m", fh.NewName);
            Assert.Equal(FileHeader.ChangeTypeEnum.ADD, fh.getChangeType());
            Assert.Equal(FileHeader.PatchTypeEnum.UNIFIED, fh.getPatchType());
		    Assert.True(fh.hasMetaDataChanges());
		    Assert.Same(FileMode.Missing, fh.GetOldMode());
		    Assert.Same(FileMode.RegularFile, fh.NewMode);
		    Assert.Equal("0000000", fh.getOldId().name());
		    Assert.Equal("7898192", fh.getNewId().name());
		    Assert.Equal(0, fh.getScore());
        [StrictFactAttribute]
		    Assert.Equal("\u00c5ngstr\u00f6m", fh.OldName);
		    Assert.Equal("/dev/null", fh.NewName);
		    Assert.Same(FileHeader.DEV_NULL, fh.NewName);
            Assert.Equal(FileHeader.ChangeTypeEnum.DELETE, fh.getChangeType());
            Assert.Equal(FileHeader.PatchTypeEnum.UNIFIED, fh.getPatchType());
		    Assert.True(fh.hasMetaDataChanges());
		    Assert.Same(FileMode.RegularFile, fh.GetOldMode());
		    Assert.Same(FileMode.Missing, fh.NewMode);
		    Assert.Equal("7898192", fh.getOldId().name());
		    Assert.Equal("0000000", fh.getNewId().name());
		    Assert.Equal(0, fh.getScore());
        [StrictFactAttribute]
		    Assert.Equal("a b", fh.OldName);
		    Assert.Equal("a b", fh.NewName);
		    Assert.Equal(FileHeader.ChangeTypeEnum.MODIFY, fh.getChangeType());
            Assert.Equal(FileHeader.PatchTypeEnum.UNIFIED, fh.getPatchType());
		    Assert.True(fh.hasMetaDataChanges());
		    Assert.Null(fh.getOldId());
		    Assert.Null(fh.getNewId());
		    Assert.Same(FileMode.RegularFile, fh.GetOldMode());
		    Assert.Same(FileMode.ExecutableFile, fh.NewMode);
		    Assert.Equal(0, fh.getScore());
        [StrictFactAttribute]
		    Assert.True(ptr > 0);
		    Assert.Null(fh.OldName); // can't parse names on a rename
		    Assert.Null(fh.NewName);
		    Assert.True(ptr > 0);
		    Assert.Equal("a", fh.OldName);
		    Assert.Equal(" c/\u00c5ngstr\u00f6m", fh.NewName);
		    Assert.Equal(FileHeader.ChangeTypeEnum.RENAME, fh.getChangeType());
            Assert.Equal(FileHeader.PatchTypeEnum.UNIFIED, fh.getPatchType());
		    Assert.True(fh.hasMetaDataChanges());
		    Assert.Null(fh.getOldId());
		    Assert.Null(fh.getNewId());
		    Assert.Null(fh.GetOldMode());
		    Assert.Null(fh.NewMode);
		    Assert.Equal(100, fh.getScore());
        [StrictFactAttribute]
		    Assert.True(ptr > 0);
		    Assert.Null(fh.OldName); // can't parse names on a rename
		    Assert.Null(fh.NewName);
		    Assert.True(ptr > 0);
		    Assert.Equal("a", fh.OldName);
		    Assert.Equal(" c/\u00c5ngstr\u00f6m", fh.NewName);
            Assert.Equal(FileHeader.ChangeTypeEnum.RENAME, fh.getChangeType());
            Assert.Equal(FileHeader.PatchTypeEnum.UNIFIED, fh.getPatchType());
		    Assert.True(fh.hasMetaDataChanges());
		    Assert.Null(fh.getOldId());
		    Assert.Null(fh.getNewId());
		    Assert.Null(fh.GetOldMode());
		    Assert.Null(fh.NewMode);
		    Assert.Equal(100, fh.getScore());
        [StrictFactAttribute]
		    Assert.True(ptr > 0);
		    Assert.Null(fh.OldName); // can't parse names on a copy
		    Assert.Null(fh.NewName);
		    Assert.True(ptr > 0);
		    Assert.Equal("a", fh.OldName);
		    Assert.Equal(" c/\u00c5ngstr\u00f6m", fh.NewName);
		    Assert.Equal(FileHeader.ChangeTypeEnum.COPY, fh.getChangeType());
		    Assert.Equal(FileHeader.PatchTypeEnum.UNIFIED, fh.getPatchType());
		    Assert.True(fh.hasMetaDataChanges());
		    Assert.Null(fh.getOldId());
		    Assert.Null(fh.getNewId());
		    Assert.Null(fh.GetOldMode());
		    Assert.Null(fh.NewMode);
		    Assert.Equal(100, fh.getScore());
        [StrictFactAttribute]
		    Assert.Equal("a", fh.OldName);
		    Assert.Equal("a", fh.NewName);
		    Assert.Same(FileMode.RegularFile, fh.GetOldMode());
		    Assert.Same(FileMode.RegularFile, fh.NewMode);
		    Assert.False(fh.hasMetaDataChanges());
		    Assert.NotNull(fh.getOldId());
		    Assert.NotNull(fh.getNewId());
		    Assert.True(fh.getOldId().isComplete());
		    Assert.True(fh.getNewId().isComplete());
		    Assert.Equal(ObjectId.FromString(oid), fh.getOldId().ToObjectId());
		    Assert.Equal(ObjectId.FromString(nid), fh.getNewId().ToObjectId());
		[StrictFactAttribute]
		    Assert.Equal("a", fh.OldName);
		    Assert.Equal("a", fh.NewName);
		    Assert.False(fh.hasMetaDataChanges());
		    Assert.Null(fh.GetOldMode());
		    Assert.Null(fh.NewMode);
		    Assert.NotNull(fh.getOldId());
		    Assert.NotNull(fh.getNewId());
		    Assert.True(fh.getOldId().isComplete());
		    Assert.True(fh.getNewId().isComplete());
		    Assert.Equal(ObjectId.FromString(oid), fh.getOldId().ToObjectId());
		    Assert.Equal(ObjectId.FromString(nid), fh.getNewId().ToObjectId());
        [StrictFactAttribute]
		    Assert.Equal("a", fh.OldName);
		    Assert.Equal("a", fh.NewName);
		    Assert.Same(FileMode.RegularFile, fh.GetOldMode());
		    Assert.Same(FileMode.RegularFile, fh.NewMode);
		    Assert.False(fh.hasMetaDataChanges());
		    Assert.NotNull(fh.getOldId());
		    Assert.NotNull(fh.getNewId());
		    Assert.False(fh.getOldId().isComplete());
		    Assert.False(fh.getNewId().isComplete());
		    Assert.Equal(oid.Substring(0, a - 1), fh.getOldId().name());
		    Assert.Equal(nid.Substring(0, a - 1), fh.getNewId().name());
		    Assert.True(ObjectId.FromString(oid).startsWith(fh.getOldId()));
		    Assert.True(ObjectId.FromString(nid).startsWith(fh.getNewId()));
        [StrictFactAttribute]
		    Assert.Equal("a", fh.OldName);
		    Assert.Equal("a", fh.NewName);
		    Assert.Null(fh.GetOldMode());
		    Assert.Null(fh.NewMode);
		    Assert.False(fh.hasMetaDataChanges());
		    Assert.NotNull(fh.getOldId());
		    Assert.NotNull(fh.getNewId());
		    Assert.False(fh.getOldId().isComplete());
		    Assert.False(fh.getNewId().isComplete());
		    Assert.Equal(oid.Substring(0, a - 1), fh.getOldId().name());
		    Assert.Equal(nid.Substring(0, a - 1), fh.getNewId().name());
		    Assert.True(ObjectId.FromString(oid).startsWith(fh.getOldId()));
		    Assert.True(ObjectId.FromString(nid).startsWith(fh.getNewId()));
		    Assert.True(ptr > 0);
		    Assert.True(ptr > 0);